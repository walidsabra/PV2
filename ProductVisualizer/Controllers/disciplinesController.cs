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
    public class disciplinesController : Controller
    {
        private PVModel db = new PVModel();

        // GET: disciplines
        public ActionResult Index()
        {
            return View(db.disciplines.ToList());
        }

        // GET: disciplines/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            discipline discipline = db.disciplines.Find(id);
            if (discipline == null)
            {
                return HttpNotFound();
            }
            return View(discipline);
        }

        // GET: disciplines/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: disciplines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DisciplineId,DisciplineName")] discipline discipline)
        {
            if (ModelState.IsValid)
            {
                db.disciplines.Add(discipline);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(discipline);
        }

        // GET: disciplines/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            discipline discipline = db.disciplines.Find(id);
            if (discipline == null)
            {
                return HttpNotFound();
            }
            return View(discipline);
        }

        // POST: disciplines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DisciplineId,DisciplineName")] discipline discipline)
        {
            if (ModelState.IsValid)
            {
                db.Entry(discipline).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(discipline);
        }

        // GET: disciplines/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            discipline discipline = db.disciplines.Find(id);
            if (discipline == null)
            {
                return HttpNotFound();
            }
            return View(discipline);
        }

        // POST: disciplines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            discipline discipline = db.disciplines.Find(id);
            db.disciplines.Remove(discipline);
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
