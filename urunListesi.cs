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
    
    public partial class urunListesi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public urunListesi()
        {
            this.cariSatis = new HashSet<cariSatis>();
            this.irsaliye = new HashSet<irsaliye>();
            this.pesinSatis = new HashSet<pesinSatis>();
        }
    
        public int ulNo { get; set; }
        public Nullable<int> urunKodu { get; set; }
        public double birimFiyat { get; set; }
        public int miktar { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cariSatis> cariSatis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<irsaliye> irsaliye { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pesinSatis> pesinSatis { get; set; }
        public virtual urun urun { get; set; }
    }
}
