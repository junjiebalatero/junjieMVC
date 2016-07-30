//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace junjieComWebApp.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class table_concessionaire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public table_concessionaire()
        {
            this.table_maintenance_order = new HashSet<table_maintenance_order>();
            this.table_promissory_note = new HashSet<table_promissory_note>();
            this.table_service_request = new HashSet<table_service_request>();
            this.table_waiver = new HashSet<table_waiver>();
            this.table_watermeter_receipt = new HashSet<table_watermeter_receipt>();
        }
    
        public int concessionaire_id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string account_no { get; set; }
        public string photo { get; set; }
        public string photo_alt_text { get; set; }
        public string purok { get; set; }
        public string barangay { get; set; }
        public string city { get; set; }
        public string neighbor { get; set; }
        public Nullable<System.DateTime> birth_date { get; set; }
        public string contact_no { get; set; }
        public string occupation { get; set; }
        public Nullable<int> age { get; set; }
        public string sex { get; set; }
        public string civil_status { get; set; }
        public string birth_place { get; set; }
        public string employer_name { get; set; }
        public string employer_address { get; set; }
        public string father_name { get; set; }
        public string father_address { get; set; }
        public string mother_name { get; set; }
        public string mother_address { get; set; }
        public string spouse_name { get; set; }
        public string sp_father_name { get; set; }
        public string sp_father_address { get; set; }
        public string sp_mother_name { get; set; }
        public string sp_mother_address { get; set; }
        public Nullable<System.DateTime> date_file { get; set; }
        public string classification { get; set; }
        public string meter_brand { get; set; }
        public string meter_serial_no { get; set; }
        public Nullable<int> initial_reading { get; set; }
        public string connection_size { get; set; }
        public string system_adequate { get; set; }
        public string plumber_available { get; set; }
        public string inspected_by { get; set; }
        public Nullable<System.DateTime> date_inspected { get; set; }
        public string copy_received_by { get; set; }
        public string installation_fee { get; set; }
        public string inspection_fee { get; set; }
        public string others { get; set; }
        public string total_amount_due { get; set; }
        public Nullable<int> o_r_number { get; set; }
        public Nullable<System.DateTime> o_r_receipt_date { get; set; }
        public string o_r_amount { get; set; }
        public Nullable<int> saddle_clamp_quantity { get; set; }
        public string saddle_clamp_unit { get; set; }
        public Nullable<int> lm_poly_pipe_1_2_quantity { get; set; }
        public string lm_poly_pipe_1_2_unit { get; set; }
        public Nullable<int> lm_poly_pipe_3_4_quantity { get; set; }
        public string lm_poly_pipe_3_4_unit { get; set; }
        public Nullable<int> replacement_piece_1_2_quantity { get; set; }
        public string replacement_piece_1_2_unit { get; set; }
        public Nullable<int> replacement_piece_3_4_quantity { get; set; }
        public string replacement_piece_3_4_unit { get; set; }
        public Nullable<int> g_i_elbow_1_2_x_90_quantity { get; set; }
        public string g_i_elbow_1_2_x_90_unit { get; set; }
        public Nullable<int> g_i_elbow_1_x_90_quantity { get; set; }
        public string g_i_elbow_1_x_90_unit { get; set; }
        public Nullable<int> g_i_elbow_2_x_90_quantity { get; set; }
        public string g_i_elbow_2_x_90_unit { get; set; }
        public Nullable<int> g_i_st_elbow_1_2_x_90_quantity { get; set; }
        public string g_i_st_elbow_1_2_x_90_unit { get; set; }
        public Nullable<int> g_i_st_elbow_3_4_x_90_quantity { get; set; }
        public string g_i_st_elbow_3_4_x_90_unit { get; set; }
        public Nullable<int> g_i_pipe_1_2_quantity { get; set; }
        public string g_i_pipe_1_2_unit { get; set; }
        public Nullable<int> g_i_meterstand_1_2_x_12_quantity { get; set; }
        public string g_i_meterstand_1_2_x_12_unit { get; set; }
        public Nullable<int> g_i_meterstand_1_2_x_24_quantity { get; set; }
        public string g_i_meterstand_1_2_x_24_unit { get; set; }
        public Nullable<int> g_i_nipple_1_2_x_4_quantity { get; set; }
        public string g_i_nipple_1_2_x_4_unit { get; set; }
        public Nullable<int> g_i_nipple_1_2_x_6_quantity { get; set; }
        public string g_i_nipple_1_2_x_6_unit { get; set; }
        public Nullable<int> g_i_nipple_1_2_x_8_quantity { get; set; }
        public string g_i_nipple_1_2_x_8_unit { get; set; }
        public Nullable<int> g_i_nipple_1_2_x_10_quantity { get; set; }
        public string g_i_nipple_1_2_x_10_unit { get; set; }
        public Nullable<int> g_i_reduced_elbow_1_2_x_3_4_90_quantity { get; set; }
        public string g_i_reduced_elbow_1_2_x_3_4_90_unit { get; set; }
        public Nullable<int> g_i_reduced_tee_3_4_x_2_quantity { get; set; }
        public string g_i_reduced_tee_3_4_x_2_unit { get; set; }
        public Nullable<int> g_i_cross_tee_1_2_quantity { get; set; }
        public string g_i_cross_tee_1_2_unit { get; set; }
        public Nullable<int> g_i_cross_tee_3_4_quantity { get; set; }
        public string g_i_cross_tee_3_4_unit { get; set; }
        public Nullable<int> g_i_cross_tee_1_quantity { get; set; }
        public string g_i_cross_tee_1_unit { get; set; }
        public Nullable<int> g_i_plug_1_2_quantity { get; set; }
        public string g_i_plug_1_2_unit { get; set; }
        public Nullable<int> g_i_plug_3_4_quantity { get; set; }
        public string g_i_plug_3_4_unit { get; set; }
        public Nullable<int> g_i_plug_1_quantity { get; set; }
        public string g_i_plug_1_unit { get; set; }
        public Nullable<int> g_i_bushing_1_2_x_3_4_quantity { get; set; }
        public string g_i_bushing_1_2_x_3_4_unit { get; set; }
        public Nullable<int> g_i_bushing_1_x_3_4_quantity { get; set; }
        public string g_i_bushing_1_x_3_4_unit { get; set; }
        public Nullable<int> g_i_bushing_2_x_3_4_quantity { get; set; }
        public string g_i_bushing_2_x_3_4_unit { get; set; }
        public Nullable<int> g_i_st_coupling_1_2_quantity { get; set; }
        public string g_i_st_coupling_1_2_unit { get; set; }
        public Nullable<int> g_i_st_coupling_3_4_quantity { get; set; }
        public string g_i_st_coupling_3_4_unit { get; set; }
        public Nullable<int> tapelon_quantity { get; set; }
        public string tapelon_unit { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<table_maintenance_order> table_maintenance_order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<table_promissory_note> table_promissory_note { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<table_service_request> table_service_request { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<table_waiver> table_waiver { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<table_watermeter_receipt> table_watermeter_receipt { get; set; }
    }
}
