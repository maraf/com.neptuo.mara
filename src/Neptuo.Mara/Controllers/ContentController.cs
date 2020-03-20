using Neptuo.Mara.Models.Books;
using Neptuo.Mara.Models.Resumes;
using Neptuo.Mara.Models.Timelining;
using Newtonsoft.Json;
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

        private ResumeModel LoadResume() 
            => JsonConvert.DeserializeObject<ResumeModel>(System.IO.File.ReadAllText(Request.MapPath("~/App_Data/Resume.json")));

        public ActionResult Resume()
        {
            ResumeModel model = LoadResume();
            return View("Resume", model);
        }

        public ActionResult ResumeJson()
        {
            ResumeModel model = LoadResume();
            return Json(model);
        }

        public ActionResult NotFound()
        {
            return View();
        }
    }
}