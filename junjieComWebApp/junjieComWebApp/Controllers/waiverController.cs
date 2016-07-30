using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace junjieComWebApp.Controllers
{
    public class waiverController : Controller
    {
        private junjie_commercialEntities db = new junjie_commercialEntities();

        // GET: waiver
        public ActionResult Index()
        {
            var table_waiver = db.table_waiver.Include(t => t.table_concessionaire);
            return View(table_waiver.ToList());
        }

        // GET: waiver/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table_waiver table_waiver = db.table_waiver.Find(id);
            if (table_waiver == null)
            {
                return HttpNotFound();
            }
            return View(table_waiver);
        }

        // GET: waiver/Create
        public ActionResult Create()
        {
            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name");
            return View();
        }

        // POST: waiver/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "waiver_id,concessionaire_id,waiver_date")] table_waiver table_waiver)
        {
            if (ModelState.IsValid)
            {
                db.table_waiver.Add(table_waiver);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name", table_waiver.concessionaire_id);
            return View(table_waiver);
        }

        // GET: waiver/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table_waiver table_waiver = db.table_waiver.Find(id);
            if (table_waiver == null)
            {
                return HttpNotFound();
            }
            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name", table_waiver.concessionaire_id);
            return View(table_waiver);
        }

        // POST: waiver/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "waiver_id,concessionaire_id,waiver_date")] table_waiver table_waiver)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_waiver).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name", table_waiver.concessionaire_id);
            return View(table_waiver);
        }

        // GET: waiver/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table_waiver table_waiver = db.table_waiver.Find(id);
            if (table_waiver == null)
            {
                return HttpNotFound();
            }
            return View(table_waiver);
        }

        // POST: waiver/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            table_waiver table_waiver = db.table_waiver.Find(id);
            db.table_waiver.Remove(table_waiver);
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
