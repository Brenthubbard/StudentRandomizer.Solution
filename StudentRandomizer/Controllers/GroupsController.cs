using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentRandomizer.Models;
using System.Linq;

namespace StudentRandomizer.Controllers
{
  [ApiController]
  [Route("[controller]")]
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
    public async Task<ActionResult<IEnumerable<Group>>> Get(int groupId)
    {
      var query = _db.Groups.AsQueryable();

      if (groupId != null)
        {
          query = query.Where(m => m.GroupId == groupId);
        }
      return await query.ToListAsync();
    }

    // GET with id
    [HttpGet("{id}")]
    public async Task<ActionResult<Group>> GetGroup(int id)
    {
      var group = await _db.Groups.FirstOrDefaultAsync(m => m.GroupId == id);

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

    //Create GroupStudent
    [HttpPost]
    public async Task<ActionResult<GroupStudent>> CreateGroupStudent(GroupStudent groupStudent)
    {
      _db.GroupStudent.Add(groupStudent);
      await _db.SaveChangesAsync();
      return CreatedAtAction("Post", new { id = groupStudent.GroupStudentId },
      groupStudent);
    }

  }
}