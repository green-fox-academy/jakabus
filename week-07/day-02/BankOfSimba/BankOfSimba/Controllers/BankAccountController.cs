using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    public class BankAccountController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("data")]
        public IActionResult Data()
        {
            List<BankAccount> BankAccountDatabase = new List<BankAccount>
                {
                new BankAccount(){ Name="Simba", Balance=5000, AnimalType="Lion", IsKing=true, IsGoodGuy=true },
                new BankAccount(){ Name="Mufasa", Balance=32000, AnimalType="Lion", IsKing=true, IsGoodGuy=true },
                new BankAccount(){ Name="Zazu", Balance=3000, AnimalType="Hornbill", IsKing=false, IsGoodGuy=true },
                new BankAccount(){ Name="Timon", Balance=20, AnimalType="Meerkat", IsKing=false, IsGoodGuy=true },
                new BankAccount(){ Name="Pumba", Balance=0, AnimalType="Warthog", IsKing=false, IsGoodGuy=true },
                new BankAccount(){ Name="Scar", Balance=400000, AnimalType="Lion", IsKing=true, IsGoodGuy=false }
            };
            return View(BankAccountDatabase);
        }

        [HttpGet("simba")]
        public IActionResult Simba()
        {
            BankAccount account = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = "Lion",
                IsKing = true,
                IsGoodGuy = true
            };
            return View(account);
        }
    }
}