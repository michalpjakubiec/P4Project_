//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATH_kino
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seans
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seans()
        {
            this.Rezerwacja = new HashSet<Rezerwacja>();
        }
    
        public int ID_Seans { get; set; }
        public int ID_Sala { get; set; }
        public int ID_Film { get; set; }
        public System.DateTime Data { get; set; }
        public System.TimeSpan Godzina { get; set; }
    
        public virtual Film Film { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezerwacja> Rezerwacja { get; set; }
        public virtual Sala Sala { get; set; }
    }
}