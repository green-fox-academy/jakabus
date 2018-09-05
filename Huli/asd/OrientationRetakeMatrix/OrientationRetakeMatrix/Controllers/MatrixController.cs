using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrientationRetakeMatrix.Models;
using OrientationRetakeMatrix.Services;

namespace OrientationRetakeMatrix.Controllers
{
    public class MatrixController : Controller
    {
        private MatrixService mService;

        public MatrixController(MatrixService mService)
        {
            this.mService = mService;
        }

        public IActionResult Index(Matrices matrix)
        {
            return View(matrix);
        }

        [HttpGet("/getmatrix")]
        public IActionResult Matrices(int id)
        {
            return RedirectToAction("Index", mService.LoadMatrix(id)); 
        }

        [HttpPost("/updatematrix")]
        public IActionResult Checker(Matrices matrix)
        {
            return RedirectToAction("Index", mService.UpdateMatrix(matrix));
        }

        [HttpPost("/remove/{id}")]
        public IActionResult Remove(int id)
        {
            return RedirectToAction("Index", mService.RemoveMatrix(id));
        }

        [HttpPost("/remove")]
        public IActionResult RemoveMatrix(int id)
        {
            return RedirectToAction("Index", mService.RemoveMatrix(id));
        }
    }
}