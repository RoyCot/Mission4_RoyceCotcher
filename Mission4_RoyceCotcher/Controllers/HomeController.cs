using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4_RoyceCotcher.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4_RoyceCotcher.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MovieSubmitContext _MovieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieSubmitContext movie)
        {
            _logger = logger;
            _MovieContext = movie;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Movie(MovieSubmit ms)
        {
            _MovieContext.Add(ms);
            _MovieContext.SaveChanges();
            return View("Confirmation", ms);
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
