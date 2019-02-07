using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class ClockController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowText()
        {
            return Content("Displaying text");
        }

        public IActionResult ShowJSON()
        {
            return  Json(new {Text="JSON",Description = "Displaying JSON object"});
            //Json({"Text":"JSON",Description:"Displaying JSON"});
        }

        public IActionResult ShowHTML()
        {
            return Content("<html><p><i>Hello! You are trying to view <u>something!</u></i></p></html>", "text/html");
        }

        public IActionResult ShowView()
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
