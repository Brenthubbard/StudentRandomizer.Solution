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
      return CreatedAtAction("Post", new { id = match.MatchId }, match);
    }

    // GET
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Match>>> Get(int matchId, int matchScore)
    {
      var query = _db.Matches.AsQueryable();

      if (matchId != null)
      {
        query = query.Where(m => m.MatchId == matchId);
      }

      if (matchScore != null)
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
  }
}