using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.filters;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [RequiresAuthentication]
    [ActionResultException]
    public class HomeController : Controller
    {
        private StuManagementEntities db = new StuManagementEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Navbar()
        {
            var site = new Websiteinfo();
            ViewBag.Site = site;
            return PartialView("~/Views/Shared/Navbar.cshtml");
        }
        

        public ActionResult Sidebar()
        {
            var sidebars = db.Sidebars.ToList();
            ViewBag.Sidebars = sidebars;
            return PartialView("~/Views/Shared/Sidebar.cshtml");
        }

        public ActionResult Actionlinks()
        {
            var actionlink = db.Actiolink.ToList();
            ViewBag.Actiolink = actionlink;
            return PartialView("~/Views/Shared/Actionlinks.cshtml");
        }

    }
}