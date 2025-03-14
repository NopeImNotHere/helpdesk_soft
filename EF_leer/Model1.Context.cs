﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_leer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class oberstufe_db1Entities : DbContext
    {
        public oberstufe_db1Entities()
            : base("name=oberstufe_db1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<abgeleitet> abgeleitet { get; set; }
        public virtual DbSet<art> art { get; set; }
        public virtual DbSet<bezahlungsart> bezahlungsart { get; set; }
        public virtual DbSet<dienstleistung> dienstleistung { get; set; }
        public virtual DbSet<kunde> kunde { get; set; }
        public virtual DbSet<mitarbeiter> mitarbeiter { get; set; }
        public virtual DbSet<ort> ort { get; set; }
        public virtual DbSet<priorität> priorität { get; set; }
        public virtual DbSet<rechnung> rechnung { get; set; }
        public virtual DbSet<rechtegruppe> rechtegruppe { get; set; }
        public virtual DbSet<session> session { get; set; }
        public virtual DbSet<status> status { get; set; }
        public virtual DbSet<ticket> ticket { get; set; }
    
        public virtual ObjectResult<GetDienstleistungenByTicket_Result> GetDienstleistungenByTicket(Nullable<int> ticketID)
        {
            var ticketIDParameter = ticketID.HasValue ?
                new ObjectParameter("ticketID", ticketID) :
                new ObjectParameter("ticketID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDienstleistungenByTicket_Result>("GetDienstleistungenByTicket", ticketIDParameter);
        }
    }
}
