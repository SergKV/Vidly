using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult MovieList()
        {
            var movies = new List<Movie>
            {
                new Movie() { Name = "Movie 1" },
                new Movie() { Name = "Movie 2" },
            };

            var viewModel = new ListMovie()
            {
                Movies = movies
            };
            return View(viewModel);
        }

        [Route("movies/details/{id}")]
        public ActionResult Details(int id)
        {
            var movies = new List<Movie>
            {
                new Movie() { Name = "Movie 1" },
                new Movie() { Name = "Movie 2" },
            };

            var viewModel = new ListMovie()
            {
                Movies = movies
            };
            return View(viewModel);
        }
    }
}