using System.Collections.Generic;

namespace StudentRandomizer.Models
{
  public class Student
  {
    public int StudentId { get; set; }
    
    public string Name { get; set; }

    public ICollection<GroupStudent> GroupStudentJoinEntities { get; set; }
    public ICollection<PairStudent> PairStudentJoinEntities { get; set; }

    public Student()
    {
      this.GroupStudentJoinEntities = new HashSet<GroupStudent>();
      this.PairStudentJoinEntities = new HashSet<PairStudent>();
    }
  }
}