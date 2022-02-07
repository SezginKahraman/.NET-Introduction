using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class TuzelMusteri:Musteri   //tuzelMusteri classı'da gercekmusteri de 
                                  //musteri klasındandır
                                  //bu yuzden :Musteri yazıp inharitance yaparız
                                  //musteride olan özellikler 2 sinde de vardır

    {
        //public int Id { get; set; }
        //public string MusteriNo { get; set; } 
        // ıd ve musteri no hem gerçekte hem de tuzel de ortak olduğundan
        //onları musteri klasına veririz ve tuzel ve gerçeğe inherit ederiz.
        //engin 5.gün C#
        public string SirketAdi { get; set; }

        public string VergiNo { get; set; }

    }
}
