namespace StudentRandomizer.Models
{
  public class PairStudent
  {
    public int PairStudentId { get; set; }
    public int PairId { get; set; }
    public int StudentId { get; set; }

    public virtual Pair Pair { get; set; }
    public virtual Student Student { get; set; }
  }
}