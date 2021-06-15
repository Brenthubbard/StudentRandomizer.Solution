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
    //Create GroupStudent
    // [HttpPost]
    // public async Task<ActionResult<GroupStudent>> CreateGroupStudent(GroupStudent groupStudent)
    // {
    //   _db.GroupStudent.Add(groupStudent);
    //   await _db.SaveChangesAsync();
    //   return CreatedAtAction("Post", new { id = groupStudent.GroupStudentId },
    //   groupStudent);
    // }
  }
}