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
    
    public partial class mitarbeiter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mitarbeiter()
        {
            this.session = new HashSet<session>();
            this.ticket = new HashSet<ticket>();
            this.kunde = new HashSet<kunde>();
            this.ticket1 = new HashSet<ticket>();
        }
    
        public int PK_Mitarbeiter { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Position { get; set; }
        public string Festnetznummer { get; set; }
        public string Mobilnummer { get; set; }
        public string Email { get; set; }
        public string Passwort { get; set; }
    
        public virtual ort ort { get; set; }
        public virtual rechtegruppe rechtegruppe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<session> session { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ticket> ticket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kunde> kunde { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ticket> ticket1 { get; set; }
    }
}
