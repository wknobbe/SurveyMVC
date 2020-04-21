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
        public IActionResult Result(Survey survey)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Name = survey.Name;
                ViewBag.Location = survey.Location;
                ViewBag.Language = survey.Language;
                ViewBag.Comment = survey.Comment;
                return View("Success");
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
