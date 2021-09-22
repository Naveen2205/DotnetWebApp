using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvMovies.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Heading"] = "Index from  Hello world controller";
            return View();
        }

        public string Privacy()
        {
            return "Hello world controller";
        }

        public string GetQueryString(string name)
        {
            return name;
        }
    }
}