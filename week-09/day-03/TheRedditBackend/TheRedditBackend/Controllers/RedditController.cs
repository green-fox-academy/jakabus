using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheRedditBackend.Models;
using TheRedditBackend.Services;

namespace TheRedditBackend.Controllers
{
    public class RedditController : Controller
    {
        private RedditService service;

        public RedditController(RedditService service)
        {
            this.service = service;
        }
        [HttpPost("index")]
        public IActionResult Index(string userName, string passWord)
        {
            return Redirect(service.Login(userName, passWord));
        }

        [HttpGet("wall")]
        public IActionResult Wall()
        {
            return View(service.GetPosts());
        }

        [HttpGet("reddit")]
        public IActionResult Reddit()
        {
            return View();
        }
    }
}