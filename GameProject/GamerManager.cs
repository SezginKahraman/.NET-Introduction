using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidation userValidation;

        public GamerManager(IUserValidation userValidation)
        {
            this.userValidation = userValidation;
        }

        public void Add(Gamer gamer)
        {
            if (userValidation.Validate(gamer) == true)
            {
                Console.WriteLine("oyuncu eklendi");
            }
            else
            {
                Console.WriteLine("doğrulama başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("oyuncu silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("oyuncu güncellendi");
        }
    }
}
