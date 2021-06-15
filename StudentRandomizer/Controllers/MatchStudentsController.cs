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
  public class MatchStudentsController : ControllerBase
  {
    // CREATE MatchStudent
    // [HttpPost]
    // public async Task<ActionResult<MatchStudent>> CreateMatchStudent(MatchStudent matchStudent)
    // {
    //   _db.MatchStudent.Add(matchStudent);
    //   await _db.SaveChangesAsync();
    //   return CreatedAtAction("Post", new { id = matchStudent.MatchStudentId }, matchStudent);
    // }

  }
}