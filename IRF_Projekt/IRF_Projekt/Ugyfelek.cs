//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IRF_Projekt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ugyfelek
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ugyfelek()
        {
            this.Foglalasok = new HashSet<Foglalasok>();
        }
    
        public int UgyfelekID { get; set; }
        public string Nev { get; set; }
        public System.DateTime Szuldat { get; set; }
        public string Telefon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Foglalasok> Foglalasok { get; set; }
    }
}
