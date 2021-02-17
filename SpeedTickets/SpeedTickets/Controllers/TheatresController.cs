using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpeedTickets.Models;

namespace SpeedTickets.Controllers
{
    public class TheatresController : Controller
    {
        MovieBookingDetailsEntities dbEntities = new MovieBookingDetailsEntities();
        // GET: Theatres
        public ActionResult Index()
        {
            var theatreInfo = dbEntities.tblTheaters.ToList();
            return View(theatreInfo);
        }
        public ActionResult AddTheatre()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTheatre(tblTheater theatres)
        {
            dbEntities.tblTheaters.Add(theatres);
            dbEntities.SaveChanges();
            return View();
        }
        public ActionResult UpdateTheatre(int? TheaterId)
        {
            var theatre = dbEntities.tblTheaters.Find(TheaterId);
            return View(theatre);
        }
        public ActionResult DeleteTheatre()
        {
            return View();
        }
    }
}