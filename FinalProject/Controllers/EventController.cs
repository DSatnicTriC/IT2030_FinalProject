using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;
using System.Data.Entity;

namespace FinalProject.Controllers
{
    public class EventController : Controller
    {
        private FinalProjectDbContext db = new FinalProjectDbContext();

        // GET: Event
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(string searchEventsQuery, string locationQuery)
        {
            var matchingEvents = db.Events.Include(e => e.Organizer).Include(e => e.EventType)
                .Where(x => x.Title.Contains(searchEventsQuery) 
                            || x.Description.Contains(searchEventsQuery)
                            || x.Location.Contains(locationQuery))
                .ToList();
            return View("SearchResults", matchingEvents);
        }
    }
}