// using System.Collections.Generic;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using StudentRandomizer.Models;
// using System.Linq;

// namespace StudentRandomizer.Controllers
// {
//   [ApiController]
//   [Route("api/[controller]")]
//   public class MatchStudentsController : ControllerBase
//   {
//     private readonly StudentRandomizerContext _db;

//     public MatchStudentsController(StudentRandomizerContext db)
//     {
//       _db = db;
//     }

//     private bool MatchStudentExists(int id)
//     {
//       return  _db.MatchStudent.Any(ms => ms.MatchStudentId == id);
//     }

//     // POST
//     [HttpPost]
//     public async Task<ActionResult<MatchStudent>> CreateMatchStudent(MatchStudent matchStudent)
//     {
//       _db.MatchStudent.Add(matchStudent);
//       await _db.SaveChangesAsync();
//       return CreatedAtAction("Post", new { id = matchStudent.MatchStudentId }, matchStudent);
//     }

//     // GET general
//     [HttpGet]
//     public async Task<ActionResult<IEnumerable<MatchStudent>>> Get(int studentId)
//     {
//       var query = _db.MatchStudent.AsQueryable();

//       if (studentId != null)
//       {
//         query = query.Where(ms => ms.StudentId == studentId);
//       }

//       return await query.ToListAsync();
//     }

//     // GET with id
//     [HttpGet("{id}")]
//     public async Task<ActionResult<MatchStudent>> GetMatchStudent(int id)
//     {
//       var matchStudent = await _db.MatchStudent.FirstOrDefaultAsync(ms => ms.MatchStudentId == id);

//       if (matchStudent == null)
//       {
//         return NotFound();
//       }

//       return matchStudent;
//     }

//     // PUT
//     [HttpPut("{id}")]
//     public async Task<IActionResult> Put(int id, MatchStudent matchStudent)
//     {
//       if (id != matchStudent.MatchStudentId)
//       {
//         return BadRequest();
//       }

//       _db.Entry(matchStudent).State = EntityState.Modified;

//       try
//       {
//         await _db.SaveChangesAsync();
//       }
//       catch (DbUpdateConcurrencyException)
//       {
//         if (!MatchStudentExists(id))
//         {
//           return NotFound();
//         }
//         else
//         {
//           throw;
//         }

//       }
      
//       return NoContent();
//     }

//     // DELETE
//     [HttpDelete("{id}")]
//     public async Task<IActionResult> DeleteMatchStudent(int id)
//     {
//       var matchStudent = await _db.MatchStudent.FindAsync(id);

//       if (matchStudent == null)
//       {
//         return NotFound();
//       }

//       _db.MatchStudent.Remove(matchStudent);
//       await _db.SaveChangesAsync();

//       return NoContent();
//     }


//   }
// }