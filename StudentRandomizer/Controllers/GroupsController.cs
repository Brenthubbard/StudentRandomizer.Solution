using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentRandomizer.Models;
using System.Linq;

namespace StudentRandomizer.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class GroupsController : ControllerBase
  {
    private readonly StudentRandomizerContext _db;
    public GroupsController(StudentRandomizerContext db)
    {
      _db = db;
    }

    private bool GroupExists(int id)
    {
      return _db.Groups.Any(g => g.GroupId == id);
    }

    // POST
    [HttpPost]
    public async Task<ActionResult<Group>> Post(Group group)
    {
      _db.Groups.Add(group);
      await _db.SaveChangesAsync();
      return CreatedAtAction("Post", new { id = group.GroupId }, group);
    }

    //Get 
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Group>>> Get()
    {
      return await _db.Groups.ToListAsync();
    }

    // GET with id
    [HttpGet("{id}")]
    public async Task<ActionResult<Group>> GetGroup(int id)
    {
      var group = await _db.Groups.FirstOrDefaultAsync(g => g.GroupId == id);

      if (group == null)
      {
        return NotFound();
      }

      return group;
    }

    //PUT with id
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Group group)
    {
      if (id != group.GroupId)
      {
        return BadRequest();
      }

      _db.Entry(group).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!GroupExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    // Delete with id 
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteGroup(int id)
    {
      var group = await _db.Groups.FindAsync(id);

      if (group == null)
      {
        return NotFound();
      }

      _db.Groups.Remove(group);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    //Post api/Groups/AddStudent/{id}
    [HttpPost("AddStudent/{id}")]
    public async Task<IActionResult> AddStudent(int id, Student student)
    {
      Group selectedGroup = await _db.Groups.FindAsync(id);
      Student selectedStudent = await _db.Students.FindAsync(student.StudentId);
      if (selectedGroup == null || selectedStudent == null)
      {
        return BadRequest();
      }

      _db.GroupStudent.Add(new GroupStudent()
      {
        GroupId = selectedGroup.GroupId,
        StudentId = selectedStudent.StudentId,
        // Group = selectedGroup,
        // Student = selectedStudent
      });

      await _db.SaveChangesAsync();

      return NoContent();
    }

    // DELETE /api/Groups/Student/{id}
    [HttpDelete("{id}/Student/{studentId}")]
    public async Task<IActionResult> DeleteStudent(int id, int studentId)
    {
      GroupStudent joinEntry = await _db.GroupStudent.FirstOrDefaultAsync(m => m.GroupId == id && m.StudentId == studentId);

      if (joinEntry == null)
      {
        return NotFound();
      }

      _db.GroupStudent.Remove(joinEntry);
      await _db.SaveChangesAsync();
      return NoContent();
    }

    // Get api/Groups/GetStudents/{id}
    [HttpGet("GetStudent/{id}")]
    public async Task<ActionResult<IEnumerable<GroupStudent>>> GetStudents(int id)
    {
      List<GroupStudent> joinEntries = await _db.GroupStudent.Where(entry => entry.StudentId == id).ToListAsync();
      return joinEntries;
    }
  }
}