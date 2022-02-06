using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4Movies.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Movies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MovieContext blahContext { get; set; }

        //Constructor
        public HomeController(ILogger<HomeController> logger, MovieContext someName)
        {
            _logger = logger;
            blahContext = someName;

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Movies(MovieModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            blahContext.Add(model);
            blahContext.SaveChanges();
            return View("Confirmation", model);

        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
