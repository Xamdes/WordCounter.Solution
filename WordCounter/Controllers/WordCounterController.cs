using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WordCounter.Models;

namespace WordCounter.Controllers
{

  public class WordCounterController : Controller
  {
    [HttpGet("/wordcounter")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/word/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpGet("/count")]
    public ActionResult Count()
    {
      return View(Word.GetCurrentWord());
    }

    [HttpPost("/word")]
    public ActionResult Create(string userWord, string listOfWords)
    {
      Word newWord =  new Word(userWord,listOfWords);
      newWord.Save();
      //int count = word.Count();
      return RedirectToAction("Count");
    }
  }
}
