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
    
    public partial class rechtegruppe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rechtegruppe()
        {
            this.mitarbeiter = new HashSet<mitarbeiter>();
        }
    
        public Nullable<bool> Administrationsrechte { get; set; }
        public Nullable<decimal> Bestelllimit { get; set; }
        public Nullable<bool> Helpdesk_Fernwartung { get; set; }
        public int PK_Rechtegruppe { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mitarbeiter> mitarbeiter { get; set; }
    }
}
