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
    public class maintenance_orderController : Controller
    {
        private junjie_commercialEntities db = new junjie_commercialEntities();

        // GET: maintenance_order
        public ActionResult Index()
        {
            var table_maintenance_order = db.table_maintenance_order.Include(t => t.table_concessionaire);
            return View(table_maintenance_order.ToList());
        }

        // GET: maintenance_order/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table_maintenance_order table_maintenance_order = db.table_maintenance_order.Find(id);
            if (table_maintenance_order == null)
            {
                return HttpNotFound();
            }
            return View(table_maintenance_order);
        }

        // GET: maintenance_order/Create
        public ActionResult Create()
        {
            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name");
            return View();
        }

        // POST: maintenance_order/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "maintenance_order_id,concessionaire_id,maintenance_date,nature_of_maintenance,maintenance_remarks")] table_maintenance_order table_maintenance_order)
        {
            if (ModelState.IsValid)
            {
                db.table_maintenance_order.Add(table_maintenance_order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name", table_maintenance_order.concessionaire_id);
            return View(table_maintenance_order);
        }

        // GET: maintenance_order/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table_maintenance_order table_maintenance_order = db.table_maintenance_order.Find(id);
            if (table_maintenance_order == null)
            {
                return HttpNotFound();
            }
            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name", table_maintenance_order.concessionaire_id);
            return View(table_maintenance_order);
        }

        // POST: maintenance_order/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "maintenance_order_id,concessionaire_id,maintenance_date,nature_of_maintenance,maintenance_remarks")] table_maintenance_order table_maintenance_order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_maintenance_order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name", table_maintenance_order.concessionaire_id);
            return View(table_maintenance_order);
        }

        // GET: maintenance_order/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table_maintenance_order table_maintenance_order = db.table_maintenance_order.Find(id);
            if (table_maintenance_order == null)
            {
                return HttpNotFound();
            }
            return View(table_maintenance_order);
        }

        // POST: maintenance_order/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            table_maintenance_order table_maintenance_order = db.table_maintenance_order.Find(id);
            db.table_maintenance_order.Remove(table_maintenance_order);
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
