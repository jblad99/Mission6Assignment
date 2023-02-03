using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6Assignment.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MoviesContext blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MoviesContext someName)
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
        public IActionResult Confirmation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MoviesForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MoviesForm(MoviesResponse mr)
        {
            blahContext.Add(mr);
            blahContext.SaveChanges();

            return View("Confirmation", mr);
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
