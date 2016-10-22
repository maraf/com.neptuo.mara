using Neptuo.AspNet.Navigation;
using Neptuo.Mara.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Neptuo.Mara.Navigation
{
    [RouteName("Book")]
    [RouteUrl("book")]
    [RouteController("Content", nameof(ContentController.Books))]
    public class BookRoute
    {
    }
}