using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;//namespace cs//

using CountingWords;
namespace RepeatCounterT
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void CheckingGetW()
    {
        //Arrange
      string test_W = "Hello";
      string test_S = "Epicodus";
      RepeatCounter newTest = new RepeatCounter(test_W, test_S);
      //Act
      string total_W = newTest.GetWord();
      string total_S = newTest.GetString();
       //Assert
      Assert.AreEqual(test_W, total_W);
      Assert.AreEqual(test_S, total_S);
    }

    [TestMethod]
    public void Testing2()
    {
      string testingOne = "Good";
      string testingTwo = "Bye";
      RepeatCounter newTest = new RepeatCounter(testingOne, testingTwo);

      string totalWord = newTest.GetWord();
      string totalString = newTest.GetString();

      Assert.AreEqual(testingOne, totalWord);
      Assert.AreEqual(testingTwo, totalString);
    }

    [TestMethod]
    public void TestPass()
    {
      string testingOne = "Good";
      string testingTwo = "Bye";
      RepeatCounter newTest = new RepeatCounter(testingOne, testingTwo);

      string totalWord = newTest.GetWord();
      string totalString = newTest.GetString();
      int total = newTest.WordTotal();

      Assert.AreEqual(testingOne, totalWord);
      Assert.AreEqual(testingTwo, totalString);
      Assert.AreEqual(0 , total);
    }


  }
}
