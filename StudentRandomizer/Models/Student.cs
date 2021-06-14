namespace StudentRandomizer.Models
{
  public class Student
  {
    public string Name { get; set; }
    public Student(string name)
    {
      this.Name = name;
    }
  }
}