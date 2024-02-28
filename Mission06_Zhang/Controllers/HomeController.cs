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
            ViewBag.Categories = _movieContext.Categories
                .OrderBy(x => x.CategoryId)
                .ToList();


            return View(new Movie());
        }

        [HttpPost]
        public IActionResult MoviesCollectionForm(Movie response)
        {
            
            if (ModelState.IsValid)
            {
                _movieContext.Movies.Add(response);//add record to the database
                _movieContext.SaveChanges();
                return View("AddingConfirmation", response);

            }
            else //empty form submitted 
            {
                ViewBag.Categories = _movieContext.Categories
                .OrderBy(x => x.CategoryId)
                .ToList();
                return View(response);
            }

        }
        public IActionResult AddingConfirmation(Movie response)
        {
            var movieAdded = _movieContext.Movies
                .Where(x => x.MovieId == response.MovieId).ToList();
            return View();
        }


        [HttpGet]
        public IActionResult DisplayCollection()
        {
            var form = _movieContext.Movies
                .OrderBy(x => x.MovieId).ToList();

            return View(form);
        }

        public IActionResult Edit(int id)
        {
            var updateRecord = _movieContext.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _movieContext.Categories
                .OrderBy(x => x.CategoryId)
                .ToList();
            return View("MoviesCollectionForm", updateRecord);
        }

        [HttpPost]
        public IActionResult Edit(Movie update)
        {
            _movieContext.Update(update);
            _movieContext.SaveChanges();
            return RedirectToAction("DisplayCollection", update.MovieId);
        }

        public IActionResult Delete(int id)
        {
            var deleteRecord = _movieContext.Movies
                .Single(x => x.MovieId == id);
            return View(deleteRecord);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _movieContext.Movies.Remove(movie);
            _movieContext.SaveChanges();

            return RedirectToAction("DisplayCollection");
        }
    }
}
    