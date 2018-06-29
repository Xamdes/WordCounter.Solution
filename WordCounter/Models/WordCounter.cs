using System;
using System.Collections.Generic;
//using System.Numerics;

namespace WordCounter.Models
{
  public class Word
  {
    private string _word;
    private string[] _wordList;

    public Word()
    {
      _word = "";
    }

    public Word(string word, string[] wordList)
    {
      _word = word;
      _wordList = wordList;
    }

    public Word(string word, string wordList)
    {
      _word = word;
      wordList = wordList.Trim();
      _wordList = wordList.Split(' ');
    }

    public void Clear()
    {
      _word = "";
      _wordList = null;
    }

    public int Count()
    {
      return RepeatCounter.Count(_word,_wordList);
    }

    //Check if Unit Test setup correctly
    public bool Default()
    {
      return true;
    }
  }

  //Using internal restricts access to just classes within the namespace
  internal static class RepeatCounter
  {
    public static int Count(string word, string[] wordList)
    {
      int count = 0;
      foreach (string w in wordList)
      {
        if(w==word)
        {
          count++;
        }
      }
      return count;
    }
  }
}
