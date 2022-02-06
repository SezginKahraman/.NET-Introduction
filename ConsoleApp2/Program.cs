using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)

        {

            string[] kurslar = new string[] { "yazılım geliştirme", "java", "python" };


            for (int i = 0; i < kurslar.Length; i += 2)
            {
                Console.WriteLine(i);
            }


            Class1 elma = new Class1();

            elma.Adi = "amasya Elması";
            elma.Adi = "mmh Midem kazındı elması";
            elma.Fiyati = 5;

            Class1 karpuz = new Class1();
            karpuz.Adi = "diyarbakır karpuzu";
            karpuz.Fiyati = 5;
            karpuz.Acıklama = "çok tatlı";


            Class1[] urunler = new Class1[] { elma, karpuz };


            foreach (Class1 urun in urunler)
            {
                Console.WriteLine(urun);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine(urun.Fiyati);

            }

            Console.WriteLine("-------------------------------------metodlar---------");


            SepetManager manager = new SepetManager();

            manager.Ekle(elma);


        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    }
}
