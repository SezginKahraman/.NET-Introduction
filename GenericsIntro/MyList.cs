using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // özel tipten gelir, Mylistimde T ile çalışıcam demektir
    {

        T[] items;
        //constructor => class ' ı newlersek otomatik çalışan bloktur ! 
        //pythondaki __init__' e denk gelir
        //zaten diğer public' ile başlayanlar da python'daki def lere denk gelir !,
        //engin 4.gün C#
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T eleman)
        {
            T[] geciciDizi = items; //tempArray yukarda ilk baştaki array'in referans numarasını
                                    //tutar
            items = new T[items.Length + 1];

            for (int i = 0; i < geciciDizi.Length; i++)
            {
                items[i] = geciciDizi[i];
            }

            items[items.Length - 1] = eleman;
        }

    }
}
