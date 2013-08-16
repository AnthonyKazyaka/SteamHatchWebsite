using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SteamHatchWebsite.Controllers
{
    public class ProjectsController : Controller
    {
        //
        // GET: /Projects/

        public ActionResult Index()
        {
            return View("~/Views/Projects/Projects.cshtml");
        }

    }
}
