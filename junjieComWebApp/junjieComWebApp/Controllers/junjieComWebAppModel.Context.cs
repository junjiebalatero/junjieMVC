﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class junjie_commercialEntities : DbContext
    {
        public junjie_commercialEntities()
            : base("name=junjie_commercialEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<table_concessionaire> table_concessionaire { get; set; }
        public virtual DbSet<table_maintenance_order> table_maintenance_order { get; set; }
        public virtual DbSet<table_promissory_note> table_promissory_note { get; set; }
        public virtual DbSet<table_service_request> table_service_request { get; set; }
        public virtual DbSet<table_waiver> table_waiver { get; set; }
        public virtual DbSet<table_watermeter_receipt> table_watermeter_receipt { get; set; }
    }
}
