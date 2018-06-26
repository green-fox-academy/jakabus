using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    public class BankAccController : Controller
    {
        List<BankAccount> Accounts = new List<BankAccount>();

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Simba()
        {
            var bankAcc = new BankAccount("Jason", 1000, "allat");

            return null;
        }
    }
}