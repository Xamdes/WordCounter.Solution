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
    [TestMethod]
    public void Return_True_Test_One()
    {
      Word word = new Word();
      Assert.AreEqual(true,word.Default());
    }
    //Start test cases
    [TestMethod]
    public void Return_testOne_1_Test_Two()
    {
      Word word = new Word("testOne", "testOne testTwo");
      Assert.AreEqual(1,word.Count());
    }
    [TestMethod]
    public void Return_testTwo_1_Test_Three()
    {
      Word word = new Word("testTwo","testOne testTwo testtwo");
      Assert.AreEqual(1,word.Count());
    }
    [TestMethod]
    public void Return_testTwo_1_Array_Test_Four()
    {
      string[] testArray = {"testOne","testTwo","testtwo"};
      Word word = new Word("testTwo",testArray);
      Assert.AreEqual(1,word.Count());
    }
    [TestMethod]
    public void Return_testTwo_2_Test_Five()
    {
      Word word = new Word("testTwo","testOne testTwo testtwo testTwo test");
      Assert.AreEqual(2,word.Count());
    }
    [TestMethod]
    public void Return_testTwo_2_ws_Test_Six()
    {
      Word word = new Word("testTwo","    testOne testTwo testtwo testTwo test    ");
      Assert.AreEqual(2,word.Count());
    }
    //Turn Case sensitive off
    [TestMethod]
    public void Return_testTwo_4_cs_Test_Seven()
    {
      Word word = new Word("testTwo","testOne testTwo testtwo testTwo test teSTtWO");
      Assert.AreEqual(4,word.Count(false));
    }
    //Whitespace or empty should return 0
    [TestMethod]
    public void Test_Eight_Blank()
    {
      Word word = new Word("","  1    1  ");
      Assert.AreEqual(0,word.Count(false));
    }

  }
}
