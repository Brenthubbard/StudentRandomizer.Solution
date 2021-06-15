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
  public class MatchsController : ControllerBase
  {
    private readonly StudentRandomizerContext _db;
    public MatchsController(StudentRandomizerContext db)
    {
      _db = db;
    }
  }
}