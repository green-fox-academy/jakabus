using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataBaseGyak.Models;
using DataBaseGyak.Services;

namespace DataBaseGyak.Controllers
{
    public class AttractionController : Controller
    {
        private AttractionService service;

        public AttractionController(AttractionService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
