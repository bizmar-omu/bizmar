<<<<<<< HEAD
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
    
    public partial class urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public urun()
        {
            this.sayac = new HashSet<sayac>();
            this.urunListesi = new HashSet<urunListesi>();
        }
    
        public int urunKodu { get; set; }
        public string barkodNo { get; set; }
        public int stokMiktari { get; set; }
        public double satisFiyati { get; set; }
        public int irsaliyeNo { get; set; }
        public string urunAd { get; set; }
    
        public virtual irsaliye irsaliye { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sayac> sayac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<urunListesi> urunListesi { get; set; }
    }
}
=======
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kar_zarar_rapor
{
    using System;
    using System.Collections.Generic;
    
    public partial class urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public urun()
        {
            this.sayac = new HashSet<sayac>();
        }
    
        public int urunKodu { get; set; }
        public string barkodNo { get; set; }
        public int stokMiktari { get; set; }
        public double satisFiyati { get; set; }
        public string urunAd { get; set; }
        public Nullable<int> tNo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sayac> sayac { get; set; }
        public virtual urun urun1 { get; set; }
        public virtual urun urun2 { get; set; }
    }
}
>>>>>>> e9a4d3f (kar zarar raporu oluşturuldu ve tamamlandı)
