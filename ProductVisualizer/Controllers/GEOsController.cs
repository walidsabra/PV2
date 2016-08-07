using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProductVisualizer.Models;

namespace ProductVisualizer.Controllers
{
    public class GEOsController : Controller
    {
        private PVModel db = new PVModel();

        // GET: GEOs
        public ActionResult Index()
        {
            return View(db.GEOS.ToList());
        }

        // GET: GEOs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GEO gEO = db.GEOS.Find(id);
            if (gEO == null)
            {
                return HttpNotFound();
            }
            return View(gEO);
        }

        // GET: GEOs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GEOs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GEOId,GEOName")] GEO gEO)
        {
            if (ModelState.IsValid)
            {
                db.GEOS.Add(gEO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gEO);
        }

        // GET: GEOs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GEO gEO = db.GEOS.Find(id);
            if (gEO == null)
            {
                return HttpNotFound();
            }
            return View(gEO);
        }

        // POST: GEOs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GEOId,GEOName")] GEO gEO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gEO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gEO);
        }

        // GET: GEOs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GEO gEO = db.GEOS.Find(id);
            if (gEO == null)
            {
                return HttpNotFound();
            }
            return View(gEO);
        }

        // POST: GEOs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GEO gEO = db.GEOS.Find(id);
            db.GEOS.Remove(gEO);
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
