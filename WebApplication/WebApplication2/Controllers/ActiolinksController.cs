using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ActiolinksController : Controller
    {
        private StuManagementEntities db = new StuManagementEntities();

        // GET: Actiolinks
        public ActionResult Index()
        {
            return View(db.Actiolink.ToList());
        }

        // GET: Actiolinks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actiolink actiolink = db.Actiolink.Find(id);
            if (actiolink == null)
            {
                return HttpNotFound();
            }
            return View(actiolink);
        }

        // GET: Actiolinks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Actiolinks/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Controller,Action")] Actiolink actiolink)
        {
            if (ModelState.IsValid)
            {
                db.Actiolink.Add(actiolink);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(actiolink);
        }

        // GET: Actiolinks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actiolink actiolink = db.Actiolink.Find(id);
            if (actiolink == null)
            {
                return HttpNotFound();
            }
            return View(actiolink);
        }

        // POST: Actiolinks/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Controller,Action")] Actiolink actiolink)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actiolink).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actiolink);
        }

        // GET: Actiolinks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actiolink actiolink = db.Actiolink.Find(id);
            if (actiolink == null)
            {
                return HttpNotFound();
            }
            return View(actiolink);
        }

        // POST: Actiolinks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Actiolink actiolink = db.Actiolink.Find(id);
            db.Actiolink.Remove(actiolink);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
