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
  public class StudentsController : ControllerBase
  {
    private readonly StudentRandomizerContext _db;
    public StudentsController(StudentRandomizerContext db)
    {
      _db = db;
    }

    private bool StudentExists(int id)
    {
      return _db.Students.Any(s => s.StudentId == id);
    }

    //Post
    [HttpPost]
    public async Task<ActionResult<Student>> Post(Student student)
    {
      _db.Students.Add(student);
      await _db.SaveChangesAsync();
      return CreatedAtAction("Post", new { id = student.StudentId }, student);
    }

    //Get
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Student>>> Get()
    {
      return await _db.Students.ToListAsync();
    }

    // GET with id
    [HttpGet("{id}")]
    public async Task<ActionResult<Student>> GetStudent(int id)
    {
      var student = await _db.Students.FindAsync(id);

      if (student == null)
      {
        return NotFound();
      }

      return student;
    }

    // PUT with id
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Student student)
    {
      if (id != student.StudentId)
      {
        return BadRequest();
      }

      _db.Entry(student).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!StudentExists(id))
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
    public async Task<IActionResult> DeleteStudent(int id)
    {
      var student = await _db.Students.FindAsync(id);

      if (student == null)
      {
        return NotFound();
      }

      _db.Students.Remove(student);
      await _db.SaveChangesAsync();

      return NoContent();
    }

  }
}