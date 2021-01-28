using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2.models;

namespace Assignment2.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Grades")]
        public IActionResult Grades()
        {
            return View();
        }

        //Over load this function to handle the model
        [HttpPost("Grades")]
        public IActionResult Grades(GradesModel model)
        {
            return View();
        }
    }
}
