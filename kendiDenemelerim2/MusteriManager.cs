using System;
using System.Collections.Generic;
using System.Text;

namespace kendiDenemelerim2
{
    class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri>();

        public void musteriEkleme(List<Musteri> musteris) 
        {
            musteriler.Add(new Musteri { Id =4});
        
        
        }
        public void musteriCıkarma(Musteri musteri)
        {
            Console.WriteLine("müşteri çıkarıldı");
        }

        public void musteriListeleme(List<Musteri> musteri)
        {
            Console.WriteLine("müşteriler listelendi");
        }

    }
}
