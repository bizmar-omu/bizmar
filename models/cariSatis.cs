//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bizmar.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class cariSatis
    {
        public int csNo { get; set; }
        public System.DateTime csTarih { get; set; }
        public double csTutar { get; set; }
        public Nullable<int> ulNo { get; set; }
        public Nullable<int> mNo { get; set; }
    
        public virtual musteri musteri { get; set; }
        public virtual urunListesi urunListesi { get; set; }
    }
}
