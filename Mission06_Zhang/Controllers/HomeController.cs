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
            return View();
        }

        [HttpPost]
        public IActionResult MoviesCollectionForm(Movies response)
        {
            _movieContext.movies.Add(response);//add record to the database
            _movieContext.SaveChanges();
            return View("index", response);
        }

    }
}
