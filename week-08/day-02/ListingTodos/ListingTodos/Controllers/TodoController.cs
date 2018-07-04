using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingTodos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ListingTodos.Controllers
{
    [Route("/todo")]
    public class TodoController : Controller
    {
        private TodoContext todoContext;

        public TodoController(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route("/list")]
        public IActionResult List()
        {
            return Content("This is my first mindfuck of the day yey!");
        }

    }
}