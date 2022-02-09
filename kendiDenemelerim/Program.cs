using System;
using System.Collections.Generic;

namespace kendiDenemelerim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Product elma = new Product();
            // pythondaki urun = Product()  
            // yani hesap1 = BankaUygulaması()
            // artık şunu yapabilirim
            // hesap1.paraEkle(200)
            //hesap1.paraCıkar(100)

            elma.adı = "elma";
            elma.fiyatı = 2;
            elma.Id = 3;
            elma.unitInStock = "2";
            elma.özelliği = "Amasaya elması";

            Product armut = new Product();
            armut.adı = "armut";
            armut.fiyatı = 3;
            armut.Id = 4;
            armut.unitInStock = "5";
            armut.özelliği = "Bursa armutu";

            Product[] urunler = new Product[] { elma, armut};

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.adı + " " + urun.fiyatı + 
                    " "+ urun.unitInStock);
            }

            //üsttekş urunler array'ine ben yeni bir ürün ekleyemiuyorum
            //bu yüzden tekrardan List, yani ürün ekleyebileceğim bir colection
            //oluşturuyorum
            Console.WriteLine("------------ilk kod bloğu bitişi------");
            List<Product> uruns = new List<Product> {elma, armut };

            uruns.Add(new Product {Id=2, adı="karpuz",unitInStock="3",
            fiyatı=4, özelliği="diyarbakır karpuzu"});

            foreach (var urun in uruns)
            {
                Console.WriteLine(urun.özelliği);
            }
            Console.WriteLine("foreach döngüsü bitti-----------");

            for (int i = 0; i < uruns.Count; i++)
            {
                Console.WriteLine(uruns[i].özelliği);
            }
            Console.WriteLine("------for döngüsü bitti--------");
            int a = 0;

            while (a < uruns.Count)
            {
                Console.WriteLine(uruns[a].özelliği);
                
                a= a + 1;
            }



        }
    }

    class Product
    {
        public int Id { get; set; }
        public string adı { get; set; }
        public string özelliği { get; set; }
        public int fiyatı { get; set; }
        public string unitInStock { get; set; }


    }










}
