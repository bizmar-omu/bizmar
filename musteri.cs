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
    
    public partial class musteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public musteri()
        {
            this.cariSatis = new HashSet<cariSatis>();
            this.odeme = new HashSet<odeme>();
        }
    
        public int mNo { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string telno { get; set; }
        public double toplamSatis { get; set; }
        public double toplamBorc { get; set; }
        public Nullable<double> toplamOdenen { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cariSatis> cariSatis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<odeme> odeme { get; set; }
    }
}