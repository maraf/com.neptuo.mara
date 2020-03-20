using Neptuo.AspNet.Navigation;
using Neptuo.Mara.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuo.Mara.Navigation
{
    [RouteName("Resume")]
    [RouteUrl("resume")]
    [RouteController("Content", nameof(ContentController.Resume))]
    public class ResumeRoute
    {
    }
}
