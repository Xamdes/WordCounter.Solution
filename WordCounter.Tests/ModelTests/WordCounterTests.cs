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

    // [TestInitialize]
    // public void TestInit()
    // {
    //   test = true;
    // }
    [TestMethod]
    public void Return_True()
    {
      Word word = new Word();
      Assert.AreEqual(true,word.Default());
    }
    //Start test cases
    [TestMethod]
    public void Return_testOne_1()
    {
      Word word = new Word("testOne", "testOne testTwo");
      Assert.AreEqual(1,word.Count());
    }
    [TestMethod]
    public void Return_testTwo_1()
    {
      Word word = new Word("testTwo","testOne testTwo testtwo");
      Assert.AreEqual(1,word.Count());
    }
    [TestMethod]
    public void Return_testTwo_1_Array()
    {
      string[] testArray = {"testOne","testTwo","testtwo"};
      Word word = new Word("testTwo",testArray);
      Assert.AreEqual(1,word.Count());
    }
    [TestMethod]
    public void Return_testTwo_2()
    {
      Word word = new Word("testTwo","testOne testTwo testtwo testTwo test");
      Assert.AreEqual(2,word.Count());
    }
    [TestMethod]
    public void Return_testTwo_2_ws()
    {
      Word word = new Word("testTwo","    testOne testTwo testtwo testTwo test    ");
      Assert.AreEqual(2,word.Count());
    }

  }
}
