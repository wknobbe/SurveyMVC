using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SurveyMVC.Models;

namespace SurveyMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("result")]
        public IActionResult Result(string Name, string Location, string Language, string Comment)
        {
            if(ModelState.IsValid)
            {
                Survey survey = new Survey()
                {
                    Name = Name,
                    Location = Location,
                    Language = Language,
                    Comment = Comment,
                };
                return View("Success", survey);
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
