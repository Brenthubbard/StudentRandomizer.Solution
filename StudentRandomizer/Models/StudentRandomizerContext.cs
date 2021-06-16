using Microsoft.EntityFrameworkCore;

// edited to reflect a possible solution --JS

namespace StudentRandomizer.Models
{

  public class StudentRandomizerContext : DbContext
  {
    public DbSet<Student> Students { get; set; }
    // public DbSet<StudentStudent> StudentStudents { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<GroupStudent> GroupStudent { get; set; }
    public DbSet<Match> Matches { get; set; }
    public DbSet<MatchStudent> MatchStudent { get; set; }

    public StudentRandomizerContext(DbContextOptions<StudentRandomizerContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Student>()
            .HasData(
              new Student { StudentId = 1, Name = "Ahmed Ghouzlane" },
              new Student { StudentId = 2, Name = "Brandon Magofna" },
              new Student { StudentId = 3, Name = "Brent Hubbard" },
              new Student { StudentId = 4, Name = "Carlos Mendez" },
              new Student { StudentId = 5, Name = "Cassandra Copp" },
              new Student { StudentId = 6, Name = "Cristina Plesa" },
              new Student { StudentId = 7, Name = "Giancarlo Vigneri" },
              new Student { StudentId = 8, Name = "Isaac Moreno" },
              new Student { StudentId = 9, Name = "James Wyn" },
              new Student { StudentId = 10, Name = "Jamie Knutsen" },
              new Student { StudentId = 11, Name = "Jeremy Banka" },
              new Student { StudentId = 12, Name = "Jesse White" },
              new Student { StudentId = 13, Name = "John Edmondson" },
              new Student { StudentId = 14, Name = "Jonathan Stull" },
              new Student { StudentId = 15, Name = "Marney Mallory" },
              new Student { StudentId = 16, Name = "Michael Burton" },
              new Student { StudentId = 17, Name = "Min Chang" },
              new Student { StudentId = 18, Name = "Nicholas Reeder" },
              new Student { StudentId = 19, Name = "Patrick Lee" },
              new Student { StudentId = 20, Name = "Ryan Walker" },
              new Student { StudentId = 21, Name = "Sammai Gutierrez" },
              new Student { StudentId = 22, Name = "Seth Medeiros" },
              new Student { StudentId = 23, Name = "Thomas Friedrichs" },
              new Student { StudentId = 24, Name = "Thomas Russell" },
              new Student { StudentId = 25, Name = "Tiffany Greathead" },
              new Student { StudentId = 26, Name = "Tom Geraghty" },
              new Student { StudentId = 27, Name = "Vanessa Su" }
            );
      builder.Entity<Match>()
            .HasData(
              new Match { MatchId = 1 },
              new Match { MatchId = 2 },
              new Match { MatchId = 3 },
              new Match { MatchId = 4 },
              new Match { MatchId = 5 }
            );
      builder.Entity<Group>()
            .HasData(
              new Group { GroupId = 1 },
              new Group { GroupId = 2 },
              new Group { GroupId = 3 },
              new Group { GroupId = 4 },
              new Group { GroupId = 5 }
            );
    }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //   optionsBuilder.UseLazyLoadingProxies();
    // }
  }
}