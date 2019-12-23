using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class KechengController : Controller
    {
        private StuManagementEntities db = new StuManagementEntities();
        // GET: Kecheng
        public ActionResult Kemu()
        {
            var teachers = db.Teachers.ToList();
            ViewBag.Teachers = teachers;

            var classes = db.Classes.ToList();
            ViewBag.Classes = classes;

            var coures = db.Course.ToList();
            ViewBag.Course = coures;
            return View();
        }
    }
}