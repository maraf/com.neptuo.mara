using Neptuo.AspNet.Navigation;
using Neptuo.Mara.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Neptuo.Mara.Navigation
{
    [RouteName("Home")]
    [RouteUrl("")]
    [RouteController("Content", nameof(ContentController.Home))]
    public class HomeRoute
    {
    }
}