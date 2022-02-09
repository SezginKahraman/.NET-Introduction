using System;

namespace GameProjectKendiDenemem
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaceları kullanma amacımız, kullanıldığı classların referansını tutabilmesi
            //yani bir class'a ben diğer classlardan herhangi birini parametre olarak
            //vermek istiyorsam, hepsini tutabilen interface'i parametre olarak verebilirim
            Gamer gamer = new Gamer();
            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer);

        }
    }
}
