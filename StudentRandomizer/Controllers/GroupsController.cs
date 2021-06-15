using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentRandomizer.Models;
using System.Linq;


namespace StudentRandomizer.Controllers
{
  [ApiController]
  [Route("[controller")]
  public class GroupsController : ControllerBase
  {
    private readonly StudentRandomizerContext _db;
    public GroupsController(StudentRandomizerContext db)
    {
      _db = db;
    }
    
  }
}