using System.Collections.Generic;

namespace StudentRandomizer.Models
{
  public class Group
  {
    public int GroupId { get; set; }
    // public string Name { get; set; }
    public int GroupFreq { get; set; } // should this be in the join entity?

    public virtual ICollection<GroupStudent> GroupStudentJoinEntities { get; set; }

    public Group()
    {
      this.GroupStudentJoinEntities = new HashSet<GroupStudent>();
    }
  }
}