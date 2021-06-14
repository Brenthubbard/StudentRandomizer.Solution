using System.Linq;
using System.Collections.Generic;

namespace StudentRandomizer.Models
{
  public class GroupScoring
  {
    public string Name { get; set; }
    public int StudentId { get; }
    public int StudentFrequency { get; set; }

    public int MatchFrequency(int StudentId, int MatchStudentId)
    {
      var db = Database.Open("StudentRandomizer");
      int Frequency = db.Query("Match");
      Stack<int> TempScore = new Stack<int>();
      for (int i = 0; i < Match.Count; i++)
      {
        if (StudentId == MatchStudentId)
        {
          TempScore.Push(Frequency);
        }
      }
      return TempScore;
    }

    public static int GroupScore(allGeneratedGroups)
    {
      for (int i = 0; i < allGeneratedGroups.Count; i++)
      {
        for (int j = 0; j < groupStudents.Count; j++)
        {
          MatchFrequency(j, groupStudents[j])
        }
      }

    }
    // loop through group list
    //nested loop for each group
    // in nested loop add for frequency for each pair
    // group score == adding of each nested loop

    // public int Score { get; }
    // public GroupScoring(int score)
    // {
    //   Score = score;
    // }
  }
}