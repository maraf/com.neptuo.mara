using Neptuo.Mara.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Neptuo.Mara
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapModel<HomeRoute>();
            routes.MapModel<BookRoute>();
            routes.MapModel<ResumeRoute>();

            routes.MapRoute(
                name: "Resume.json",
                url: "Resume.json",
                defaults: new { controller = "Content", action = "ResumeJson" }
            );

            routes.MapRoute(
                name: "404",
                url: "404.html",
                defaults: new { controller = "Content", action = "NotFound" }
            );

            routes.MapRoute(
                name: "ContentFallBack",
                url: "{*path}",
                defaults: new { controller = "Content", action = "NotFound" }
            );
        }
    }
}
