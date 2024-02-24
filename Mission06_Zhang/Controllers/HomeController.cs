using Microsoft.AspNetCore.Mvc;
using Mission06_Zhang.Models;
using System.Diagnostics;

namespace Mission06_Zhang.Controllers
{
    public class HomeController : Controller
    {
        private MoviesContext _movieContext;
        public HomeController(MoviesContext temp)//build the instance of the database to use in the program
        {
            _movieContext = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MoviesCollectionForm()
        {
            ViewBag.Categories = _movieContext.categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            return View();
        }

        [HttpPost]
        public IActionResult MoviesCollectionForm(Movie response)
        {
            
            _movieContext.movies.Add(response);//add record to the database
            _movieContext.SaveChanges();
            return RedirectToAction("AddingConfirmation", response);
        }
        public IActionResult AddingConfirmation(Movie response)
        {
            return View();
        }


        [HttpGet]
        public IActionResult DisplayCollection()
        {
            var form = _movieContext.movies
                .OrderBy(x => x.Year).ToList();

            return View(form);
        }

    }
}
