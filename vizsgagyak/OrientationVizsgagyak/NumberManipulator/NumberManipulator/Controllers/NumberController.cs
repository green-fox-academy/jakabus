using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NumberManipulator.Models;
using NumberManipulator.Services;

namespace NumberManipulator.Controllers
{
    public class NumberController : Controller
    {

        private NumberService nService;

        public NumberController(NumberService nService)
        {
            this.nService = nService;
        }

        public IActionResult Index(Result result)
        {
            
            return View(nService.Startpage(result));
        }

        [HttpPost("/checker")]
        public IActionResult Checker(string firstnumber, string secondnumber, string thirdnumber, string fourthnumber)
        {
            return RedirectToAction("Index", nService.Checker(firstnumber, secondnumber, thirdnumber, fourthnumber));
        }

        [HttpPost("/sum")]
        public IActionResult Sum(int sumid)
        {
            return RedirectToAction("SumThisNigga", nService.SumThisShit(sumid));
        }

        [HttpGet]
        public IActionResult SumThisNigga(Result result)
        {
            return View(result);
        }

        [HttpPost("/square")]
        public IActionResult Square(int squareid)
        {
            return RedirectToAction("SquareThisNigga", nService.SquareThisShit(squareid));
        }

        [HttpGet]
        public IActionResult SquareThisNigga(Result result)
        {
            return View(result);
        }

    }
}