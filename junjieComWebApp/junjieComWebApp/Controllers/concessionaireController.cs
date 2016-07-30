using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace junjieComWebApp.Controllers
{
    public class concessionaireController : Controller
    {
        private junjie_commercialEntities db = new junjie_commercialEntities();

        // GET: concessionaire
        public ActionResult Index(string searchBy, string search, int? page)
        {
            if (searchBy == "account_no")
            {
                return View(db.table_concessionaire.Where(x => x.account_no == search || search == null).ToList().ToPagedList(page ?? 1, 10));
            }
            else
            {
                return View(db.table_concessionaire.Where(x => x.last_name.StartsWith(search) || search == null).ToList().ToPagedList(page ?? 1, 10));
            }
        }

        // GET: concessionaire/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table_concessionaire table_concessionaire = db.table_concessionaire.Find(id);
            if (table_concessionaire == null)
            {
                return HttpNotFound();
            }
            return View(table_concessionaire);
        }

        // GET: concessionaire/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: concessionaire/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "concessionaire_id,last_name,first_name,middle_name,account_no,photo,photo_alt_text,purok,barangay,city,neighbor,birth_date,contact_no,occupation,age,sex,civil_status,birth_place,employer_name,employer_address,father_name,father_address,mother_name,mother_address,spouse_name,sp_father_name,sp_father_address,sp_mother_name,sp_mother_address,date_file,classification,meter_brand,meter_serial_no,initial_reading,connection_size,system_adequate,plumber_available,inspected_by,date_inspected,copy_received_by,installation_fee,inspection_fee,others,total_amount_due,o_r_number,o_r_receipt_date,o_r_amount,saddle_clamp_quantity,saddle_clamp_unit,lm_poly_pipe_1_2_quantity,lm_poly_pipe_1_2_unit,lm_poly_pipe_3_4_quantity,lm_poly_pipe_3_4_unit,replacement_piece_1_2_quantity,replacement_piece_1_2_unit,replacement_piece_3_4_quantity,replacement_piece_3_4_unit,g_i_elbow_1_2_x_90_quantity,g_i_elbow_1_2_x_90_unit,g_i_elbow_1_x_90_quantity,g_i_elbow_1_x_90_unit,g_i_elbow_2_x_90_quantity,g_i_elbow_2_x_90_unit,g_i_st_elbow_1_2_x_90_quantity,g_i_st_elbow_1_2_x_90_unit,g_i_st_elbow_3_4_x_90_quantity,g_i_st_elbow_3_4_x_90_unit,g_i_pipe_1_2_quantity,g_i_pipe_1_2_unit,g_i_meterstand_1_2_x_12_quantity,g_i_meterstand_1_2_x_12_unit,g_i_meterstand_1_2_x_24_quantity,g_i_meterstand_1_2_x_24_unit,g_i_nipple_1_2_x_4_quantity,g_i_nipple_1_2_x_4_unit,g_i_nipple_1_2_x_6_quantity,g_i_nipple_1_2_x_6_unit,g_i_nipple_1_2_x_8_quantity,g_i_nipple_1_2_x_8_unit,g_i_nipple_1_2_x_10_quantity,g_i_nipple_1_2_x_10_unit,g_i_reduced_elbow_1_2_x_3_4_90_quantity,g_i_reduced_elbow_1_2_x_3_4_90_unit,g_i_reduced_tee_3_4_x_2_quantity,g_i_reduced_tee_3_4_x_2_unit,g_i_cross_tee_1_2_quantity,g_i_cross_tee_1_2_unit,g_i_cross_tee_3_4_quantity,g_i_cross_tee_3_4_unit,g_i_cross_tee_1_quantity,g_i_cross_tee_1_unit,g_i_plug_1_2_quantity,g_i_plug_1_2_unit,g_i_plug_3_4_quantity,g_i_plug_3_4_unit,g_i_plug_1_quantity,g_i_plug_1_unit,g_i_bushing_1_2_x_3_4_quantity,g_i_bushing_1_2_x_3_4_unit,g_i_bushing_1_x_3_4_quantity,g_i_bushing_1_x_3_4_unit,g_i_bushing_2_x_3_4_quantity,g_i_bushing_2_x_3_4_unit,g_i_st_coupling_1_2_quantity,g_i_st_coupling_1_2_unit,g_i_st_coupling_3_4_quantity,g_i_st_coupling_3_4_unit,tapelon_quantity,tapelon_unit")] table_concessionaire table_concessionaire)
        {
            if (ModelState.IsValid)
            {
                db.table_concessionaire.Add(table_concessionaire);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table_concessionaire);
        }

        // GET: concessionaire/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table_concessionaire table_concessionaire = db.table_concessionaire.Find(id);
            if (table_concessionaire == null)
            {
                return HttpNotFound();
            }
            return View(table_concessionaire);
        }

        // POST: concessionaire/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "concessionaire_id,last_name,first_name,middle_name,account_no,photo,photo_alt_text,purok,barangay,city,neighbor,birth_date,contact_no,occupation,age,sex,civil_status,birth_place,employer_name,employer_address,father_name,father_address,mother_name,mother_address,spouse_name,sp_father_name,sp_father_address,sp_mother_name,sp_mother_address,date_file,classification,meter_brand,meter_serial_no,initial_reading,connection_size,system_adequate,plumber_available,inspected_by,date_inspected,copy_received_by,installation_fee,inspection_fee,others,total_amount_due,o_r_number,o_r_receipt_date,o_r_amount,saddle_clamp_quantity,saddle_clamp_unit,lm_poly_pipe_1_2_quantity,lm_poly_pipe_1_2_unit,lm_poly_pipe_3_4_quantity,lm_poly_pipe_3_4_unit,replacement_piece_1_2_quantity,replacement_piece_1_2_unit,replacement_piece_3_4_quantity,replacement_piece_3_4_unit,g_i_elbow_1_2_x_90_quantity,g_i_elbow_1_2_x_90_unit,g_i_elbow_1_x_90_quantity,g_i_elbow_1_x_90_unit,g_i_elbow_2_x_90_quantity,g_i_elbow_2_x_90_unit,g_i_st_elbow_1_2_x_90_quantity,g_i_st_elbow_1_2_x_90_unit,g_i_st_elbow_3_4_x_90_quantity,g_i_st_elbow_3_4_x_90_unit,g_i_pipe_1_2_quantity,g_i_pipe_1_2_unit,g_i_meterstand_1_2_x_12_quantity,g_i_meterstand_1_2_x_12_unit,g_i_meterstand_1_2_x_24_quantity,g_i_meterstand_1_2_x_24_unit,g_i_nipple_1_2_x_4_quantity,g_i_nipple_1_2_x_4_unit,g_i_nipple_1_2_x_6_quantity,g_i_nipple_1_2_x_6_unit,g_i_nipple_1_2_x_8_quantity,g_i_nipple_1_2_x_8_unit,g_i_nipple_1_2_x_10_quantity,g_i_nipple_1_2_x_10_unit,g_i_reduced_elbow_1_2_x_3_4_90_quantity,g_i_reduced_elbow_1_2_x_3_4_90_unit,g_i_reduced_tee_3_4_x_2_quantity,g_i_reduced_tee_3_4_x_2_unit,g_i_cross_tee_1_2_quantity,g_i_cross_tee_1_2_unit,g_i_cross_tee_3_4_quantity,g_i_cross_tee_3_4_unit,g_i_cross_tee_1_quantity,g_i_cross_tee_1_unit,g_i_plug_1_2_quantity,g_i_plug_1_2_unit,g_i_plug_3_4_quantity,g_i_plug_3_4_unit,g_i_plug_1_quantity,g_i_plug_1_unit,g_i_bushing_1_2_x_3_4_quantity,g_i_bushing_1_2_x_3_4_unit,g_i_bushing_1_x_3_4_quantity,g_i_bushing_1_x_3_4_unit,g_i_bushing_2_x_3_4_quantity,g_i_bushing_2_x_3_4_unit,g_i_st_coupling_1_2_quantity,g_i_st_coupling_1_2_unit,g_i_st_coupling_3_4_quantity,g_i_st_coupling_3_4_unit,tapelon_quantity,tapelon_unit")] table_concessionaire table_concessionaire)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_concessionaire).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table_concessionaire);
        }

        // GET: concessionaire/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table_concessionaire table_concessionaire = db.table_concessionaire.Find(id);
            if (table_concessionaire == null)
            {
                return HttpNotFound();
            }
            return View(table_concessionaire);
        }

        // POST: concessionaire/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            table_concessionaire table_concessionaire = db.table_concessionaire.Find(id);
            db.table_concessionaire.Remove(table_concessionaire);
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
