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
    
    public partial class bezahlungsart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bezahlungsart()
        {
            this.rechnung = new HashSet<rechnung>();
        }
    
        public string Artname { get; set; }
        public string Beschreibung { get; set; }
        public int PK_Bezahlungsart { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rechnung> rechnung { get; set; }
    }
}
