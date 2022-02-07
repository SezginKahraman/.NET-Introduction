using System;

namespace kendiDenemelerim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            yeniklas araba = new yeniklas();
            araba.MyProperty = "Nissan";

            ekleme deneme = new ekleme();
            deneme.add(2, 5);


        }
    }

    
    
    class yeniklas
    {

        public string MyProperty { get; set; }

    }

    class ekleme
    {
        public void add(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);


        }
    }












}
