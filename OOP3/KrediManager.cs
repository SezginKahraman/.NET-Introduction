using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager //burada interface yazmamızın sebebi
        // eğer class yazsaydık
        //atıyorum ihtiyac kredisinin faiz oranı ile taşıt kredisininki
        //birbirinden farklı olsun
        //class yazsaydık aynı faiz oranından hesaplardı çünkü ebeveynin özelliklerini
        // direkt olarak inherit ediyor.
        //ama temel olarak hesapla fonksiyonu ayın olduğu halde farklı işler yapıyorsa
        //class yerine interface yazılır !
        //loglamar da interface ile yazılır çünkü sms, e - mail ortak ama
        // yazıları farklı
    {
        void Hesapla();
        void BiseyYap();
        

            

        
    }
}
