using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
//using System.Numerics;
using WordCounter.Models;


namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounter
  {
    private bool test = false;

    [TestInitialize]
    public void TestInit()
    {
      test = true;
    }
    [TestMethod]
    public void Return_True()
    {
      Word word = new Word();
      Assert.AreEqual(test,word.Default());
    }

  }
}
