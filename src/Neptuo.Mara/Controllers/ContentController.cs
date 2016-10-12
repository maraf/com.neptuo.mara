using Neptuo.Mara.Models.Books;
using Neptuo.Mara.Models.Timelining;
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
            NodeDataService dataService = new NodeDataService(Request.MapPath(NodeDataService.DataUri));
            return View("Timeline", dataService.Get().GroupBy(n => n.When.Year));
        }

        public ActionResult Books()
        {
            BookDataService dataService = new BookDataService(Request.MapPath(BookDataService.DataUri));
            return View("Book", new BookListViewModel(dataService.Get(), dataService.GetAuthors()));
        }
    }
}