using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentRandomizer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRandomizer.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class MatchesController : ControllerBase
  {
    private readonly StudentRandomizerContext _db;
    public MatchesController(StudentRandomizerContext db)
    {
      _db = db;
    }

    private bool MatchExists(int id)
    {
      return _db.Matches.Any(m => m.MatchId == id);
    }

    // POST
    [HttpPost]
    public async Task<ActionResult<Match>> Post(Match match)
    {
      _db.Matches.Add(match);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetMatch), new { id = match.MatchId }, match);
    }

    // GET
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Match>>> Get(int matchId, int matchScore)
    {
      var query = _db.Matches.AsQueryable();

      if (matchId > 0)
      {
        query = query.Where(m => m.MatchId == matchId);
      }

      if (matchScore > 0)
      {
        query = query.Where(m => m.MatchScore == matchScore);
      }

      return await query.ToListAsync();
    }

    // GET with id
    [HttpGet("{id}")]
    public async Task<ActionResult<Match>> GetMatch(int id)
    {
      var match = await _db.Matches.FirstOrDefaultAsync(m => m.MatchId == id);

      if (match == null)
      {
        return NotFound();
      }

      return match;
    }

    // PUT with id
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Match match)
    {
      if (id != match.MatchId)
      {
        return BadRequest();
      }

      _db.Entry(match).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!MatchExists(id))
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
    public async Task<IActionResult> DeleteMatch(int id)
    {
      var match = await _db.Matches.FindAsync(id);

      if (match == null)
      {
        return NotFound();
      }

      _db.Matches.Remove(match);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    // /api/matches/AddStudent/{id}
    [HttpPost("AddStudent/{id}")]
    public async Task<IActionResult> AddStudent(int id, Student student)
    {
      Match thisMatch = await _db.Matches.FindAsync(id);
      Student thisStudent = await _db.Students.FindAsync(student.StudentId);

      if (thisMatch == null || thisStudent == null)
      {
        return NotFound();
      }

      _db.MatchStudent.Add(new MatchStudent()
      {
        MatchId = thisMatch.MatchId,
        StudentId = thisStudent.StudentId,
        // Match = thismatch,
        // Student = thisStudent
      });

      await _db.SaveChangesAsync();
      return NoContent();
    }

    // DELETE /api/matches/Student/{id}
    [HttpDelete("{id}/Student/{studentId}")]
    public async Task<IActionResult> DeleteStudent(int id, int studentId)
    {
      MatchStudent joinEntry = await _db.MatchStudent.FirstOrDefaultAsync(m => m.MatchId == id && m.StudentId == studentId);

      if (joinEntry == null)
      {
        return NotFound();
      }

      _db.MatchStudent.Remove(joinEntry);
      await _db.SaveChangesAsync();
      return NoContent();
    }

    // GET route that queries by studentId
    // GET api/matches/GetStudents/{id}
    [HttpGet("GetStudent/{id}")]
    public async Task<ActionResult<IEnumerable<MatchStudent>>> GetStudents(int id)
    {
      List<MatchStudent> joinEntries = await _db.MatchStudent.Where(entry => entry.StudentId == id).ToListAsync();
      return joinEntries;
    }
  }
}