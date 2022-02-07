using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManageroperasyonlar
    {

        public void Add(Productklası urun)
        {
            Console.WriteLine(urun.ProductName+ "eklendi");

        }
    
        public void Update(Productklası urun)
        {
            Console.WriteLine(urun.ProductName+"güncellendi");

        }
    
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    
    }
}
