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
    
    public partial class Gepjarmu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gepjarmu()
        {
            this.Foglalasok = new HashSet<Foglalasok>();
            this.Serulesek = new HashSet<Serulesek>();
        }
    
        public int gepjarmuSK { get; set; }
        public int TipusFK { get; set; }
        public string Rendszam { get; set; }
        public string Szin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Foglalasok> Foglalasok { get; set; }
        public virtual TipusAr TipusAr { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Serulesek> Serulesek { get; set; }
    }
}