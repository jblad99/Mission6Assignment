using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private MoviesContext mContext { get; set; }

        public HomeController(MoviesContext someName)
        {
            mContext = someName;
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
            ViewBag.Categories = mContext.Category.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult MoviesForm(MoviesResponse mr)
        {
            if (ModelState.IsValid)
            {
                mContext.Add(mr);
                mContext.SaveChanges();

            return View("Confirmation", mr);
        }
        else
            {
                ViewBag.Categories = mContext.Category.ToList();

                return View();
            }
        }
        public IActionResult MoviesList()
        {
            var applications = mContext.Responses
                .Include(x => x.Category)
                //.Where(x => x.CreeperStalker == false)
                .OrderBy(x => x.Title)
                .ToList();

            return View(applications);
        }
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = mContext.Category.ToList();

            var movie = mContext.Responses.Single(x => x.MovieId == movieid);

            return View("MoviesForm", movie);
        }
        [HttpPost]
        public IActionResult Edit(MoviesResponse blah)
        {
            //Using this to update the database
            mContext.Update(blah);
            mContext.SaveChanges();

            return RedirectToAction("MoviesList");
        }
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = mContext.Responses.Single(x => x.MovieId == movieid);

            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(MoviesResponse mr)
        {
            mContext.Responses.Remove(mr);
            mContext.SaveChanges();

            return RedirectToAction("MoviesList");
        }

    }
}
