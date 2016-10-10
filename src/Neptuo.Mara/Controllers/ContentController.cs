using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Neptuo.Mara.Controllers
{
    public class ContentController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Books()
        {
            return HttpNotFound();
        }
    }
}