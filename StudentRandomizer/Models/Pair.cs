using System;
using System.Collections.Generic;

namespace StudentRandomizer.Models
{
  public class Pair
  {
    public int PairId { get; set;}
    public int PairScore { get; set; } // should this be in the join entity?
    public virtual ICollection<PairStudent> PairStudentJoinEntities { get; set; }
    public Pair()   
    {
      this.PairStudentJoinEntities = new HashSet<PairStudent>();
    }
  }
}