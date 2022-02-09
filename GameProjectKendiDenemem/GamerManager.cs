using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectKendiDenemem
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
            if (userValidation.Validation(gamer) == true)
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
            throw new NotImplementedException();
        }

        public void Update(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    

      
    }
}
