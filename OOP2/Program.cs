using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "engin";
            //musteri1.Soyadi = "Demiroğ";
            //musteri1.Id = 1;
            //musteri1.TcNo = "21323";
            //musteri1.MusteriNo = "1231421";
            //musteri1.SirketAdi = "?";
            //musteri nin sirket adının olmaaması gerekir !!!!!
            // 2 tane nesne var, Gerçek ve tüzel !
            //SOLİD !!

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "1234";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "123154523";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "2141251421";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "231312412";


            Musteri musteri3 = new GercekMusteri(); //new bellekteki referans nosu
                                                    //Musteri klası
                                                    //hem gerçek müsterinin
                                                    // hem de tüzelin ref nosunu
                                                    //tutabiliyor !!!

            Musteri musteri4 = new TuzelMusteri();

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);

            //olay tamamen aslında referans sınıfı
            // musteri 2 referans tipini'de tutabiliyor !



        }
    }
}
