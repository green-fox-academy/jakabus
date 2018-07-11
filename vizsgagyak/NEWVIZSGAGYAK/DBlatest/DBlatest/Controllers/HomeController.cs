using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBlatest.Models;
using DBlatest.Services;

namespace DBlatest.Controllers
{
    public class HomeController : Controller
    {
        private AttractionService service;

        public HomeController(AttractionService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View(service.GetAttractions());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
