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
    public class service_requestController : Controller
    {
        private junjie_commercialEntities db = new junjie_commercialEntities();

        // GET: service_request
        public ActionResult Index()
        {
            var table_service_request = db.table_service_request.Include(t => t.table_concessionaire);
            return View(table_service_request.ToList());
        }

        // GET: service_request/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table_service_request table_service_request = db.table_service_request.Find(id);
            if (table_service_request == null)
            {
                return HttpNotFound();
            }
            return View(table_service_request);
        }

        // GET: service_request/Create
        public ActionResult Create()
        {
            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name");
            return View();
        }

        // POST: service_request/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "service_request_id,concessionaire_id,request_date,nature_of_request,remarks")] table_service_request table_service_request)
        {
            if (ModelState.IsValid)
            {
                db.table_service_request.Add(table_service_request);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name", table_service_request.concessionaire_id);
            return View(table_service_request);
        }

        // GET: service_request/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table_service_request table_service_request = db.table_service_request.Find(id);
            if (table_service_request == null)
            {
                return HttpNotFound();
            }
            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name", table_service_request.concessionaire_id);
            return View(table_service_request);
        }

        // POST: service_request/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "service_request_id,concessionaire_id,request_date,nature_of_request,remarks")] table_service_request table_service_request)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_service_request).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name", table_service_request.concessionaire_id);
            return View(table_service_request);
        }

        // GET: service_request/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table_service_request table_service_request = db.table_service_request.Find(id);
            if (table_service_request == null)
            {
                return HttpNotFound();
            }
            return View(table_service_request);
        }

        // POST: service_request/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            table_service_request table_service_request = db.table_service_request.Find(id);
            db.table_service_request.Remove(table_service_request);
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
