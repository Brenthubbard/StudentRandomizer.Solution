using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentRandomizer.Models;

namespace StudentRandomizer.Tests
{
  [TestClass]
  public class GroupScoringTests
  {
    [TestMethod]
    public void GroupScoringConstructor_CreatesInstanceOfScore_GroupScoring()
    {
      GroupScoring newGroupScoring = new GroupScoring();
      Assert.AreEqual(typeof(GroupScoring), newGroupScoring.GetType());
    }
  }
}