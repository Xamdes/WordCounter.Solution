using System;
using System.Collections.Generic;
//using System.Numerics;

namespace WordCounter.Models
{
  public class Word
  {
    private string _word;
    private List<string> _wordList;

    public Word()
    {
      _word = "";
      _wordList = new List<string>(){};
    }

    public Word(string word, List<string> wordList)
    {
      _word = word;
      _wordList = wordList;
    }

    public void Clear()
    {
      _word = "";
      _wordList = new List<string>(){};
    }
    //Check if Unit Test setup correctly
    public bool Default()
    {
      return true;
    }
  }
}
