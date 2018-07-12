using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
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