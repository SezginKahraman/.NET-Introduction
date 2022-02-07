using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Productklası urun1 = new Productklası();

            urun1.CategoryId = 1;
            urun1.Id = 2;
            urun1.UnitPrice = 3;
            urun1.UnitsInStock = 4;
            urun1.ProductName = "masa";


            Productklası urun2 = new Productklası { Id = 2, CategoryId= 5,
                ProductName="kalem",UnitsInStock=35,
                UnitPrice=25};


            ProductManageroperasyonlar ekleme = new ProductManageroperasyonlar();
            string isim = "engin";
            ekleme.Add(urun1);

        
        
        
        
        
        
        
       
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    }
}
