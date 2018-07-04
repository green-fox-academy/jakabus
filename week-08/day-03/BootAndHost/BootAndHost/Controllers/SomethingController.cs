using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootAndHost.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootAndHost.Controllers
{
    public class SomethingController : Controller
    {
        [Route("something")]
        public IActionResult Something()
        {
            var smth = new Something() { Name = "FOS"};
            //return View(smth);
            return RedirectToAction("Index", "Home", new { page = 1 , sortBy = "name"});
        }

        [Route("edit")]
        public IActionResult Edit(int id)
        {
            return Content("id= " + id);
        }
    }
}