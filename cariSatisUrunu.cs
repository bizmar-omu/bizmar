//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bizmar
{
    using System;
    using System.Collections.Generic;
    
    public partial class cariSatisUrunu
    {
        public int csuNo { get; set; }
        public string csuBarkodNo { get; set; }
        public string csuAd { get; set; }
        public int csuMiktar { get; set; }
        public double csuFiyat { get; set; }
        public int csNo { get; set; }
    
        public virtual cariSatis cariSatis { get; set; }
    }
}
