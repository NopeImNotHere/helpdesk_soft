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
    
    public partial class session
    {
        public int id { get; set; }
        public string sessionhash { get; set; }
        public System.DateTime expires_at { get; set; }
        public System.DateTime inserted_at { get; set; }
    
        public virtual kunde kunde { get; set; }
        public virtual mitarbeiter mitarbeiter { get; set; }
    }
}
