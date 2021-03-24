using Assignment3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

//This is where the program determines what view to go to based on the page and other fields.

namespace Assignment3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
        public IActionResult AddMovies()
        {
            return View();
        }

        //This says that when it is a post, we will check if input meets the requirments, if it does it will return the view which is the confirmation page.
        [HttpPost]
        public IActionResult AddMovies(MovieResponse movieResponse)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddMovie(movieResponse);
                return View("Confirmation", movieResponse);
            }
            else
            {
                return View();
            }
        }
            

        public IActionResult MovieCollection()
        {
            return View(TempStorage.Movies);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
