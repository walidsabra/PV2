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
    public class BIMUsesController : Controller
    {
        private PVModel db = new PVModel();

        // GET: BIMUses
        public ActionResult Index()
        {
            return View(db.BIMUses.ToList());
        }

        // GET: BIMUses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BIMUse bIMUse = db.BIMUses.Find(id);
            if (bIMUse == null)
            {
                return HttpNotFound();
            }
            return View(bIMUse);
        }

        // GET: BIMUses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BIMUses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BIMUseId,BIMUseName")] BIMUse bIMUse)
        {
            if (ModelState.IsValid)
            {
                db.BIMUses.Add(bIMUse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bIMUse);
        }

        // GET: BIMUses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BIMUse bIMUse = db.BIMUses.Find(id);
            if (bIMUse == null)
            {
                return HttpNotFound();
            }
            return View(bIMUse);
        }

        // POST: BIMUses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BIMUseId,BIMUseName")] BIMUse bIMUse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bIMUse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bIMUse);
        }

        // GET: BIMUses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BIMUse bIMUse = db.BIMUses.Find(id);
            if (bIMUse == null)
            {
                return HttpNotFound();
            }
            return View(bIMUse);
        }

        // POST: BIMUses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BIMUse bIMUse = db.BIMUses.Find(id);
            db.BIMUses.Remove(bIMUse);
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
