using ImdbWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImdbWebApp.Controllers
{
    public class HomeController : Controller
    {
        imdbContext db = new imdbContext();

        public ActionResult Index()
        {
            IEnumerable<Movie> Movies = db.Movies;
            ViewBag.Movies = Movies;
            return View();
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            ViewBag.MovieId = id;
            return View();
        }

        [HttpPost]
        public string Details(Actor actor, Genre genre)
        {
            db.Genres.Add(genre);
            db.Actors.Add(actor);
            db.SaveChanges();
            return "The Genre of this movie is: " + genre.Name + " And actors played in it "+ actor.SecondName;
        }
    }
}