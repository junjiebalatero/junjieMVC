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
    
    public partial class table_watermeter_receipt
    {
        public int watermeter_receipt_id { get; set; }
        public int concessionaire_id { get; set; }
        public Nullable<System.DateTime> actual_date_installed { get; set; }
        public string watermeter_receipt_remarks { get; set; }
        public string installed_by { get; set; }
    
        public virtual table_concessionaire table_concessionaire { get; set; }
    }
}