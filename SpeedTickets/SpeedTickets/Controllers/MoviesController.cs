using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpeedTickets.Models;

namespace SpeedTickets.Controllers
{
    public class MoviesController : Controller
    {
        MovieBookingDetailsEntities dbEntities = new MovieBookingDetailsEntities();
        // GET: Movies
        public ActionResult Index()
        {
            var movieInfo = dbEntities.tblMovies.ToList();
            return View(movieInfo);
        }
        public ActionResult AddMovie()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMovie(tblMovy movies)
        {
            dbEntities.tblMovies.Add(movies);
            dbEntities.SaveChanges();
            return View();
        }
        public ActionResult UpdateMovie(int? Id)
        {
            var movie = dbEntities.tblMovies.Find(Id);
            return View(movie);
        }
        [HttpPost]
        public ActionResult UpdateMovie(tblMovy movies)
        {
            dbEntities.Entry(movies).State = EntityState.Modified;
            dbEntities.SaveChanges();
            return View(movies);
        }
        public ActionResult DeleteMovie()
        {
            return View();
        }
    }
}