using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Namer.Services;

namespace Namer.Controllers
{
    public class NameController : Controller
    {
        private NameService nameService;

        public NameController(NameService nameService)
        {
            this.nameService = nameService;
        }

        public IActionResult Index()
        {
            return View(nameService.GetNames());
        }

        [HttpPost("/nameit")]
        public IActionResult Namez(string firstname, string lastname)
        {
            nameService.NameIt(firstname, lastname);
            return RedirectToAction("Index"); 
        }

        [HttpPost("/delit")]
        public IActionResult KillName(int id)
        {
            nameService.DeleteName(id);
            return RedirectToAction("Index");
        }
    }
}