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
    
    public partial class ticket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ticket()
        {
            this.abgeleitet = new HashSet<abgeleitet>();
            this.rechnung = new HashSet<rechnung>();
            this.mitarbeiter1 = new HashSet<mitarbeiter>();
        }
    
        public int PK_Ticket { get; set; }
        public string Ticket_Titel { get; set; }
        public string Beschreibung { get; set; }
        public string InterneNotiz { get; set; }
        public string InternerStatus { get; set; }
        public Nullable<System.DateTime> Erstelldatum { get; set; }
        public Nullable<System.DateTime> Bearbeitungsdatum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<abgeleitet> abgeleitet { get; set; }
        public virtual art art { get; set; }
        public virtual kunde kunde { get; set; }
        public virtual mitarbeiter mitarbeiter { get; set; }
        public virtual priorität priorität { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rechnung> rechnung { get; set; }
        public virtual status status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mitarbeiter> mitarbeiter1 { get; set; }
    }
}
