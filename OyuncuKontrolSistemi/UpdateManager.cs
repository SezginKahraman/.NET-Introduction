using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuKontrolSistemi
{
    class UpdateManager
    {
        public void Update(Gamer gamer,string Ad, string Soyad,string Doğumyılı, string TCNo)
        {
            gamer.Ad = Ad;
            gamer.DoğumYılı = Doğumyılı;
            gamer.SoyAd = Soyad;
            gamer.TCNo = TCNo;

        }

    }
}
