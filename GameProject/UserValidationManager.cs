using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DoğumTarihi == "1985" && gamer.Name == "Sezgin"
                && gamer.LastName == "Kahraman" && gamer.Id == "213213")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
