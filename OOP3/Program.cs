using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            TasıtKrediManager tasıtKrediManager = new TasıtKrediManager();
            tasıtKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            //interface lar 'de classlar gibi referans numarasını tutabiliyor !
            ILoggerService DataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileBaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new DataBaseLoggerService);

            Console.WriteLine("-----------------------------");

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,
            tasıtKrediManager};

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}
