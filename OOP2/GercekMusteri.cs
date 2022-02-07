using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class GercekMusteri:Musteri //gerçek müşterinin ebeveyni Musteri 'dir
                                //Musteri'nin özelliklerini miras alır
                                // ama kendi özellikleri de vardır
    {
        //public int Id { get; set; }
        //public string MusteriNo { get; set; }
        //yukarıda bunların yorum satırını kaldırırsak uyarı verir.
        //bunun sebebi zaten musteri de bunları yazdık !!
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
