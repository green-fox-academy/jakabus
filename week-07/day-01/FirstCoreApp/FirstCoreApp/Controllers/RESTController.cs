using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstCoreApp.Controllers
{
    public class RESTController : Controller
    {   
        [Route("api")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("greeting")]
        public IActionResult Greeting()
        {
            return new JsonResult("Greeting");
        }
    }
}