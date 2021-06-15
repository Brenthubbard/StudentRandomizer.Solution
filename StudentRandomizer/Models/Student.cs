using System.Collections.Generic;

// edited to reflect possible solution --JS

namespace StudentRandomizer.Models
{
  public class Student
  {
    public int StudentId { get; set; }

    public string Name { get; set; }

    // public ICollection<StudentStudent> Join { get; set; }

    // public ICollection<GroupStudent> GroupStudentJoinEntities { get; set; }
    // public ICollection<MatchStudent> MatchStudentJoinEntities { get; set; }

    public Student()
    {
      // this.Join = new HashSet<StudentStudent>();

      // this.GroupStudentJoinEntities = new HashSet<GroupStudent>();
      // this.MatchStudentJoinEntities = new HashSet<MatchStudent>();
    }
  }
}