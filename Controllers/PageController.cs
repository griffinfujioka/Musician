using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Musician.Controllers
{
    public class PageController : Controller
    {
        //
        // GET: /Page/

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult About()
        {
            return View(); 
        }

        public ActionResult Media()
        {
            return View(); 
        }

        public ActionResult UpcomingEvents()
        {
            return View(); 
        }

        public ActionResult Booking()
        {
            return View();
        }

    }
}
