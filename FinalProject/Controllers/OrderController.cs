using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Order(int eventId, int quantity)
        {
            return View();
        }
    }
}