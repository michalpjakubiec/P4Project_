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
    
    public partial class Rola
    {
        public int ID_Rola { get; set; }
        public int ID_Film { get; set; }
        public int ID_Aktor { get; set; }
        public string Nazwa { get; set; }
    
        public virtual Aktor Aktor { get; set; }
        public virtual Film Film { get; set; }
    }
}