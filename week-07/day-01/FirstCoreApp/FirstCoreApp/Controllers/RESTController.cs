using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstCoreApp.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        static int apiCallCounter = 0;

        [Route("api")]
        public IActionResult Index()
        {
            return View();
        }

        
        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            apiCallCounter++;
            Greeting greeting = new Greeting()
            {
                Id = apiCallCounter,
                Content = "Hello " + name 
            };
            return new JsonResult(greeting);
        }
    }
}