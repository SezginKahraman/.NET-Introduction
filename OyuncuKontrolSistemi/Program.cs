using System;

namespace OyuncuKontrolSistemi
{
    class Program
    {
        static void Main(string[] args)
        {

            Gamer oyuncu1 = new Gamer {TCNo="21321",Ad="sezgin",
            SoyAd="kahraman",DoğumYılı="2001"
            };

            UpdateManager updateManager = new UpdateManager();
            updateManager.Update(oyuncu1, "213214", "ahmet", "mehmet", "2003");


        }
    }
}
