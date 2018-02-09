using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Hangman.Models;

namespace Hangman.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Main()
        {
            return View();
        }
        [HttpGet("/play/{1}")]
        public IActionResult StageGame()
        {
            HangmanGame.GetRandomWord();
            return View();
        }
        [HttpPost("/play/{id}")]
        public IActionResult StageGame(int id)
        {   
            switch (id)
            {
            case 1:
                Console.WriteLine("Case 1");
                break;
            case 2:
                Console.WriteLine("Case 2");
                break;
            case 3:
                Console.WriteLine("Case 3");
                break;
            case 4:
                Console.WriteLine("Case 4");
                break;
            case 5:
                Console.WriteLine("Case 5");
                break;
            case 6:
                Console.WriteLine("Case 6");
                break;
            case 7:
                Console.WriteLine("Case Lose");
                break;
            case 8:
                Console.WriteLine("Case Win");
                break;    
            default:
                Console.WriteLine("ERROR:Switch Statement is out of scope.");
                break;
            }
            return View();
        }
        [HttpGet("/win")]
        public IActionResult StageWin()
        {
            return View();                       
        }
        [HttpGet("/lose")]
         public IActionResult StageLose()
        {
            return View();                       
        }
    }
}
