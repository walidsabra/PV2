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
    public class LinkersController : Controller
    {
        private PVModel db = new PVModel();

        // GET: Linkers
        public ActionResult Index()
        {
            return View(db.Links.ToList());
        }

        // GET: Linkers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Linker linker = db.Links.Find(id);
            if (linker == null)
            {
                return HttpNotFound();
            }
            return View(linker);
        }

        // GET: Linkers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Linkers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SoftwareId,ObjectId,ObjectType,comments")] Linker linker)
        {
            if (ModelState.IsValid)
            {
                db.Links.Add(linker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(linker);
        }

        // GET: Linkers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Linker linker = db.Links.Find(id);
            if (linker == null)
            {
                return HttpNotFound();
            }
            return View(linker);
        }

        // POST: Linkers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SoftwareId,ObjectId,ObjectType,comments")] Linker linker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(linker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(linker);
        }

        // GET: Linkers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Linker linker = db.Links.Find(id);
            if (linker == null)
            {
                return HttpNotFound();
            }
            return View(linker);
        }

        // POST: Linkers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Linker linker = db.Links.Find(id);
            db.Links.Remove(linker);
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
