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
    
    public partial class table_promissory_note
    {
        public int promissory_note_id { get; set; }
        public int concessionaire_id { get; set; }
        public Nullable<System.DateTime> pn_date_of_filing { get; set; }
        public string pn_amount_in_words_full { get; set; }
        public string pn_amount_in_pesos_full { get; set; }
        public Nullable<System.DateTime> pn_date_full { get; set; }
        public string pn_amount_in_words_partial { get; set; }
        public string pn_amount_in_pesos_partial { get; set; }
        public string pn_month_arrear_applied { get; set; }
        public string pn_month_starting { get; set; }
        public string pn_month_actual_due { get; set; }
        public Nullable<int> last_reading { get; set; }
    
        public virtual table_concessionaire table_concessionaire { get; set; }
    }
}
