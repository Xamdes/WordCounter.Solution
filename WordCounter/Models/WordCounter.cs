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
      return RepeatCounter.Count(_word,_wordList,true);
    }
    public int Count(bool caseSensitive)
    {
      return RepeatCounter.Count(_word,_wordList,caseSensitive);
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
    public static int Count(string word, string[] wordList,bool caseSensitive)
    {
      if(wordList.Length==1&&wordList[0]==""||word.Trim() == "")
      {
        return 0;
      }
      int count = 0;
      if(!caseSensitive)
      {
        word = word.ToLower();
      }
      string compareWord;
      foreach (string w in wordList)
      {
        compareWord = "";
        if(!caseSensitive)
        {
          compareWord = w.ToLower();
        }
        if(w==word||compareWord==word)
        {
          count++;
        }
      }
      return count;
    }
  }
}
