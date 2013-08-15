using Musician.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using NavigationRoutes;

namespace Musician
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Page", action = "Home", id = UrlParameter.Optional }
            );

            routes.MapNavigationRoute<PageController>("About", c => c.About());

            routes.MapNavigationRoute<PageController>("Music & Videos", c => c.Media());

            routes.MapNavigationRoute<PageController>("Upcoming Events", c => c.UpcomingEvents());

            routes.MapNavigationRoute<PageController>("Booking", c => c.Booking()); 


        }
    }
}