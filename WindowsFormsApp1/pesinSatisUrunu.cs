//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class pesinSatisUrunu
    {
        public int psuNo { get; set; }
        public string psuBarkodNo { get; set; }
        public string psuAd { get; set; }
        public int psuMiktar { get; set; }
        public double psuFiyat { get; set; }
        public int psNo { get; set; }
    
        public virtual pesinSatis pesinSatis { get; set; }
    }
}