using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpeedTickets.Models;

namespace SpeedTickets.Controllers
{
    public class LanguagesController : Controller
    {
        MovieBookingDetailsEntities dbEntities = new MovieBookingDetailsEntities();
        // GET: Languages
        public ActionResult Index()
        {
            var languageInfo = dbEntities.tblLanguages.ToList();
            return View(languageInfo);
        }
        public ActionResult AddLanguage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddLanguage(tblLanguage languages)
        {
            dbEntities.tblLanguages.Add(languages);
            dbEntities.SaveChanges();
            return View();
        }
        public ActionResult UpdateLanguage(int? LanguageId)
        {
            var language = dbEntities.tblLocations.Find(LanguageId);
            return View(language);
        }
        public ActionResult DeleteLanguage(int LanguageId)
        {
            return View();
        }
    }
}