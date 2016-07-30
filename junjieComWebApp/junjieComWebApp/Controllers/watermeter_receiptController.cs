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
    public class watermeter_receiptController : Controller
    {
        private junjie_commercialEntities db = new junjie_commercialEntities();

        // GET: watermeter_receipt
        public ActionResult Index()
        {
            var table_watermeter_receipt = db.table_watermeter_receipt.Include(t => t.table_concessionaire);
            return View(table_watermeter_receipt.ToList());
        }

        // GET: watermeter_receipt/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table_watermeter_receipt table_watermeter_receipt = db.table_watermeter_receipt.Find(id);
            if (table_watermeter_receipt == null)
            {
                return HttpNotFound();
            }
            return View(table_watermeter_receipt);
        }

        // GET: watermeter_receipt/Create
        public ActionResult Create()
        {
            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name");
            return View();
        }

        // POST: watermeter_receipt/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "watermeter_receipt_id,concessionaire_id,actual_date_installed,watermeter_receipt_remarks,installed_by")] table_watermeter_receipt table_watermeter_receipt)
        {
            if (ModelState.IsValid)
            {
                db.table_watermeter_receipt.Add(table_watermeter_receipt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name", table_watermeter_receipt.concessionaire_id);
            return View(table_watermeter_receipt);
        }

        // GET: watermeter_receipt/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table_watermeter_receipt table_watermeter_receipt = db.table_watermeter_receipt.Find(id);
            if (table_watermeter_receipt == null)
            {
                return HttpNotFound();
            }
            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name", table_watermeter_receipt.concessionaire_id);
            return View(table_watermeter_receipt);
        }

        // POST: watermeter_receipt/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "watermeter_receipt_id,concessionaire_id,actual_date_installed,watermeter_receipt_remarks,installed_by")] table_watermeter_receipt table_watermeter_receipt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_watermeter_receipt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name", table_watermeter_receipt.concessionaire_id);
            return View(table_watermeter_receipt);
        }

        // GET: watermeter_receipt/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table_watermeter_receipt table_watermeter_receipt = db.table_watermeter_receipt.Find(id);
            if (table_watermeter_receipt == null)
            {
                return HttpNotFound();
            }
            return View(table_watermeter_receipt);
        }

        // POST: watermeter_receipt/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            table_watermeter_receipt table_watermeter_receipt = db.table_watermeter_receipt.Find(id);
            db.table_watermeter_receipt.Remove(table_watermeter_receipt);
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
