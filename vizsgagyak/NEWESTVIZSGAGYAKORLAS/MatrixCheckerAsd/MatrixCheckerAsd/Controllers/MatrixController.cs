using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatrixCheckerAsd.Models;
using MatrixCheckerAsd.Services;
using Microsoft.AspNetCore.Mvc;

namespace MatrixCheckerAsd.Controllers
{
    public class MatrixController : Controller
    {
        private MatrixService mservice;

        public MatrixController(MatrixService mservice)
        {
            this.mservice = mservice;
        }

        [HttpGet("/")]
        public IActionResult Index(Matrix matrix)
        {
            return View(matrix);
        }

        [HttpPost("/matrix")]
        public IActionResult Checker(string MatrixNumbers)
        {
            return RedirectToAction("Index", mservice.MatrixChecker(MatrixNumbers));
        }

        [HttpGet("/matrices")]
        public IActionResult Matrices()
        {
            return Json(mservice.GetMatrices());
        }

        [HttpGet("/getmatrices")]
        public IActionResult Getmatrices()
        {
            return View(mservice.GetMatrices());
        }

        [HttpPost("/deletematrice")]
        public IActionResult DeleteMatrice(string matrixAsString)
        {
            mservice.DeleteMatrix(matrixAsString);
            return Redirect("/getmatrices");
        }
    }
}