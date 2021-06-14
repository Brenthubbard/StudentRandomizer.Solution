using Microsoft.EntityFrameworkCore;

namespace StudentRandomizer.Models
{

  public class StudentRandomizerContext : DbContext
  {
    public StudentRandomizerContext(DbContextOptions<StudentRandomizerContext> options) : base(options)
    {
    }
    public DbSet<Group> Groups { get; set;}
    public DbSet<Match> Matchs { get; set;}
    public DbSet<Student> Students { get; set;}

  }
}