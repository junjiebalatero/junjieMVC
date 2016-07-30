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
    public class promissory_noteController : Controller
    {
        private junjie_commercialEntities db = new junjie_commercialEntities();

        // GET: promissory_note
        public ActionResult Index()
        {
            var table_promissory_note = db.table_promissory_note.Include(t => t.table_concessionaire);
            return View(table_promissory_note.ToList());
        }

        // GET: promissory_note/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table_promissory_note table_promissory_note = db.table_promissory_note.Find(id);
            if (table_promissory_note == null)
            {
                return HttpNotFound();
            }
            return View(table_promissory_note);
        }

        // GET: promissory_note/Create
        public ActionResult Create()
        {
            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name");
            return View();
        }

        // POST: promissory_note/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "promissory_note_id,concessionaire_id,pn_date_of_filing,pn_amount_in_words_full,pn_amount_in_pesos_full,pn_date_full,pn_amount_in_words_partial,pn_amount_in_pesos_partial,pn_month_arrear_applied,pn_month_starting,pn_month_actual_due,last_reading")] table_promissory_note table_promissory_note)
        {
            if (ModelState.IsValid)
            {
                db.table_promissory_note.Add(table_promissory_note);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name", table_promissory_note.concessionaire_id);
            return View(table_promissory_note);
        }

        // GET: promissory_note/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table_promissory_note table_promissory_note = db.table_promissory_note.Find(id);
            if (table_promissory_note == null)
            {
                return HttpNotFound();
            }
            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name", table_promissory_note.concessionaire_id);
            return View(table_promissory_note);
        }

        // POST: promissory_note/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "promissory_note_id,concessionaire_id,pn_date_of_filing,pn_amount_in_words_full,pn_amount_in_pesos_full,pn_date_full,pn_amount_in_words_partial,pn_amount_in_pesos_partial,pn_month_arrear_applied,pn_month_starting,pn_month_actual_due,last_reading")] table_promissory_note table_promissory_note)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_promissory_note).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.concessionaire_id = new SelectList(db.table_concessionaire, "concessionaire_id", "last_name", table_promissory_note.concessionaire_id);
            return View(table_promissory_note);
        }

        // GET: promissory_note/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table_promissory_note table_promissory_note = db.table_promissory_note.Find(id);
            if (table_promissory_note == null)
            {
                return HttpNotFound();
            }
            return View(table_promissory_note);
        }

        // POST: promissory_note/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            table_promissory_note table_promissory_note = db.table_promissory_note.Find(id);
            db.table_promissory_note.Remove(table_promissory_note);
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
