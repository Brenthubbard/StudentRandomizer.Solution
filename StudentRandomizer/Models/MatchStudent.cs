namespace StudentRandomizer.Models
{
  public class MatchStudent
  {
    public int MatchStudentId { get; set; }
    public int MatchId { get; set; }
    public int StudentId { get; set; }

    public virtual Match Match { get; set; }
    public virtual Student Student { get; set; }
  }
}