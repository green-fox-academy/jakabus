using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBlatest.Models;
using DBlatest.Services;
using Microsoft.AspNetCore.Mvc;

namespace DBlatest.Controllers
{
    public class AttractionController : Controller
    {
        private AttractionService service;

        public AttractionController(AttractionService service)
        {
            this.service = service;
        }

        [HttpPost("add")]
        public IActionResult Add(Attractions attr)
        {
            service.AddAttraction(attr);
            return Redirect("home");
        }

        [HttpGet("home")]
        public IActionResult Home()
        {
            return View(service.GetAttractions());
        }

        [HttpGet("/edit/{Id}")]
        public IActionResult Edit(int id)
        {
            return View(service.GetAttractions()[id-1]);
        }

        [HttpPost("update")]
        public IActionResult Update(Attractions attr)
        {
            service.UpdateAttraction(attr);
            return RedirectToAction("home");
        }

        [HttpGet("/attractions")]
        public IActionResult Attractions()
        {
            return View();
        }
    }
}