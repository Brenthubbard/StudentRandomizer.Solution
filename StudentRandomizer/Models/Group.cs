using System.Collections.Generic;

namespace StudentRandomizer.Models
{
  public class Group
  {
    // public string Name { get; set; }

    // public int GroupSize { get; set; }

    public int GroupId { get; set; }
    public int GroupScore { get; set; }

    // public List<Student> Students { get; set; }

    // public virtual ICollection<GroupStudent> GroupStudentJoinEntities { get; set; }

    public Group()
    {
      // this.GroupStudentJoinEntities = new HashSet<GroupStudent>();
    }
  }
}