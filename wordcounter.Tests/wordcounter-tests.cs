using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;//namespace cs//

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void CheckingCounterTest()
    {
      Counter testCounter = new Counter(Test);
      Assert.AreEqual(testCounter.UserWordInput(Test));
    }
  }
}
