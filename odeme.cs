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
    
    public partial class odeme
    {
        public int odemeNo { get; set; }
        public double odemeTutari { get; set; }
        public System.DateTime odemeTarihi { get; set; }
        public Nullable<int> mNo { get; set; }
    
        public virtual musteri musteri { get; set; }
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
    
    public partial class odeme
    {
        public int odemeNo { get; set; }
        public double odemeTutari { get; set; }
        public System.DateTime odemeTarihi { get; set; }
        public Nullable<int> mNo { get; set; }
    
        public virtual musteri musteri { get; set; }
        public virtual musteri musteri1 { get; set; }
    }
}
>>>>>>> e9a4d3f (kar zarar raporu oluşturuldu ve tamamlandı)
