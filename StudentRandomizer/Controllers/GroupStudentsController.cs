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
  public class GroupStudentsController : ControllerBase
  {
    private readonly StudentRandomizerContext _db;

    public GroupStudentsController(StudentRandomizerContext db)
    {
      _db = db;
    }

    private bool GroupStudentExists(int id)
    {
      return _db.GroupStudent.Any(gs => gs.GroupStudentId == id);
    }

    // POST
    [HttpPost]
    public async Task<ActionResult<GroupStudent>> CreateGroupStudent(GroupStudent groupStudent)
    {
      _db.GroupStudent.Add(groupStudent);
      await _db.SaveChangesAsync();
      return CreatedAtAction("Post", new { id = groupStudent.GroupStudentId },
      groupStudent);
    }

    // GET general
    [HttpGet]
    public async Task<ActionResult<IEnumerable<GroupStudent>>> Get(int studentId)
    {
      var query = _db.GroupStudent.AsQueryable();

      if (studentId != null)
      {
        query = query.Where(gs => gs.StudentId == studentId);
      }

      return await query.ToListAsync();
    }

    // GET with id
    [HttpGet("{id}")]
    public async Task<ActionResult<GroupStudent>> GetGroupStudent(int id)
    {
      var groupStudent = await _db.GroupStudent.FirstOrDefaultAsync(gs => gs.GroupStudentId == id);

      if (groupStudent == null)
      {
        return NotFound();
      }

      return groupStudent;
    }

    // PUT with id
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, GroupStudent groupStudent)
    {
      if (id != groupStudent.GroupStudentId)
      {
        return BadRequest();
      }

      _db.Entry(groupStudent).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!GroupStudentExists(id))
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

    // DELETE with id
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteGroupStudent(int id)
    {
      var groupStudent = await _db.GroupStudent.FindAsync(id);

      if (groupStudent == null)
      {
        return NotFound();
      }

      _db.GroupStudent.Remove(groupStudent);
      await _db.SaveChangesAsync();

      return NoContent();
    }

  }
}