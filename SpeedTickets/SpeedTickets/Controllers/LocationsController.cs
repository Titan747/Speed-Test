using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpeedTickets.Models;

namespace SpeedTickets.Controllers
{
    public class LocationsController : Controller
    {
        MovieBookingDetailsEntities dbEntities = new MovieBookingDetailsEntities();
        // GET: Locations
        public ActionResult Index()
        {
            var locationInfo = dbEntities.tblLocations.ToList();
            return View(locationInfo);
        }
        public ActionResult AddLocation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddLocation(tblLocation locations)
        {
            dbEntities.tblLocations.Add(locations);
            dbEntities.SaveChanges();
            return View();
        }
        public ActionResult UpdateLocation(int? LocationId)
        {
            var location = dbEntities.tblLocations.Find(LocationId);
            return View(location);
        }
        public ActionResult DeleteLocation(int LocationId)
        {
            return View();
        }
    }
}