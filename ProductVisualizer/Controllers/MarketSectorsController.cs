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
    public class MarketSectorsController : Controller
    {
        private PVModel db = new PVModel();

        // GET: MarketSectors
        public ActionResult Index()
        {
            return View(db.MarketSectors.ToList());
        }

        // GET: MarketSectors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarketSector marketSector = db.MarketSectors.Find(id);
            if (marketSector == null)
            {
                return HttpNotFound();
            }
            return View(marketSector);
        }

        // GET: MarketSectors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MarketSectors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MarketSectorId,MarketSectorName")] MarketSector marketSector)
        {
            if (ModelState.IsValid)
            {
                db.MarketSectors.Add(marketSector);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(marketSector);
        }

        // GET: MarketSectors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarketSector marketSector = db.MarketSectors.Find(id);
            if (marketSector == null)
            {
                return HttpNotFound();
            }
            return View(marketSector);
        }

        // POST: MarketSectors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MarketSectorId,MarketSectorName")] MarketSector marketSector)
        {
            if (ModelState.IsValid)
            {
                db.Entry(marketSector).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(marketSector);
        }

        // GET: MarketSectors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarketSector marketSector = db.MarketSectors.Find(id);
            if (marketSector == null)
            {
                return HttpNotFound();
            }
            return View(marketSector);
        }

        // POST: MarketSectors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MarketSector marketSector = db.MarketSectors.Find(id);
            db.MarketSectors.Remove(marketSector);
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
