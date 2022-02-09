using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //önce varlıklar bulunur
            //bu projede ilk varlığımız gamer idi
            //sonra operasyonlar bulunur
            // ekleme güncelleme ve silme
            //bu operasyonlar için ilk olarak ortak bir interface açılır
            //bu burada IGamerService olarak açıldı.
            // NOT : Hiç bir class artık çıplak olarak bırakılmaz !!
            //illa bir şeyi inherit etmesi gerekir.

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = "1",
                DoğumTarihi = "1985",
                Name = "sezgin",
                LastName = "kahraman",
                IdentityNumber = "12345"
            });

        }
    }
}
