//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class rechnung
    {
        public int Rechnungsnr { get; set; }
        public string Ticketbeschreibung { get; set; }
        public string Abrechnung { get; set; }
        public Nullable<bool> Ratenzahlung { get; set; }
    
        public virtual bezahlungsart bezahlungsart { get; set; }
        public virtual kunde kunde { get; set; }
        public virtual ticket ticket { get; set; }
    }
}
