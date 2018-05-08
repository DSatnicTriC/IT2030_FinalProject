using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        public ActionResult Order(int? eventId, int? quantity)
        {
            return View();
        }
    }
}