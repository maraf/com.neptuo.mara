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

            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Content", action = "Home", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Books",
                url: "book",
                defaults: new { controller = "Content", action = "Books", id = UrlParameter.Optional }
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
