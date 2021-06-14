using System;
using System.Collections.Generic;

namespace StudentRandomizer.Models
{
  public class Match
  {
    public int MatchId { get; set;}
    public int MatchScore { get; set; } // should this be in the join entity?

    public List<Student> Students { get; set; }
    // public int MatchFreq { get; set; }
    public virtual ICollection<MatchStudent> MatchStudentJoinEntities { get; set; }
    public Match()   
    {
      this.MatchStudentJoinEntities = new HashSet<MatchStudent>();
    }
  }
}