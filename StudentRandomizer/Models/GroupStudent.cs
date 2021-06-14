namespace StudentRandomizer.Models
{
  public class GroupStudent
  {
    public int GroupStudentId { get; set; }
    public int StudentId { get; set; }
    public int GroupId { get; set; }
    public virtual Group Group { get; set; }
    public virtual Student Student { get; set; }
  }
}