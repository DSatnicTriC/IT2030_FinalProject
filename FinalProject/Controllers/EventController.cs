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
            var matchingEvents = db.Events.Include(e => e.Organizer).Include(e => e.EventType);
            
            if (string.IsNullOrWhiteSpace(searchEventsQuery) && string.IsNullOrWhiteSpace(locationQuery))
            {
                // if the queries are both empty don't filter further (return the whole set)
            }
            else if (!string.IsNullOrWhiteSpace(searchEventsQuery) && !string.IsNullOrWhiteSpace(locationQuery))
            {
                matchingEvents = matchingEvents.Where(x => (x.Title.Contains(searchEventsQuery)
                                                                || x.Description.Contains(searchEventsQuery))
                                                           && x.Location.Contains(locationQuery));
            }
            else if (!string.IsNullOrWhiteSpace(searchEventsQuery))
            {
                matchingEvents = matchingEvents.Where(x => x.Title.Contains(searchEventsQuery)
                                                           || x.Description.Contains(searchEventsQuery));
            }
            else
            {
                matchingEvents = matchingEvents.Where(x => x.Location.Contains(locationQuery));
            }
            return View("SearchResults", matchingEvents.ToList());
        }

        // GET: Event
        public ActionResult Details(int eventId)
        {
            ViewBag.Id = eventId;
            return View();
        }
    }
}