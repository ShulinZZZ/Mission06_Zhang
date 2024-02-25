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
            //ViewBag.Categories = _movieContext.categories
            //ViewBag.Categories = _movieContext.movies
            //    .OrderBy(x => x.CategoryId)
            //    .ToList();
            return View();
        }

        [HttpPost]
        public IActionResult MoviesCollectionForm(Movie response)
        {
            if(response != null && ModelState.IsValid)
            {
                _movieContext.movies.Add(response);//add record to the database
                _movieContext.SaveChanges();
                return View("AddingConfirmation", response);

            }
            else //empty form submitted 
            {
                ModelState.AddModelError(string.Empty, "Please input valid information before submit.");
                return View(response);
            }

        }
        public IActionResult AddingConfirmation(Movie response)
        {
            var movieAdded = _movieContext.movies
                .Where(x => x.MovieId == response.MovieId).ToList();
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
