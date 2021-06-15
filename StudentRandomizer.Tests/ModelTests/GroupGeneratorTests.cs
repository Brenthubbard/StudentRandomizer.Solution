using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentRandomizer.Models;
using System;
using System.Collections.Generic;

namespace StudentRandomizer.Tests
{
  [TestClass]
  public class GroupGeneratorTests
  {
    [TestMethod]
    public void GenerateAllPossibleGroups_StudentList_GroupList()
    {
      int numberOfStudents = 5;
      int groupSize = 3;
      List<Student> listOfStudents = new List<Student>();
      for (int i = 1; i <= numberOfStudents; i++)
      {
        Student newStudent = new Student("Student" + i.ToString());
        listOfStudents.Add(newStudent);
      }
      List<Group> allGroups = GroupGenerator.GenerateAllPossibleGroups(listOfStudents, groupSize);
      int groupNum = 0;
      foreach (Group group in allGroups)
      {
        groupNum++;
        Console.WriteLine("\nGroup {0}", groupNum);
        foreach (Student student in group.DevTeamStudents)
        {
          Console.WriteLine(student.Name);
        }
      }
    }
  }
}
