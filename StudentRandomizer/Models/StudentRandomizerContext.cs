using Microsoft.EntityFrameworkCore;

// edited to reflect a possible solution --JS

namespace StudentRandomizer.Models
{

  public class StudentRandomizerContext : DbContext
  {
    public DbSet<Student> Students { get; set;}
    public DbSet<StudentStudent> StudentStudents { get; set; }

    // public DbSet<Group> Groups { get; set;}
    // public DbSet<Match> Matches { get; set;}
    public StudentRandomizerContext(DbContextOptions<StudentRandomizerContext> options) : base(options)
    {
    }
  }
}