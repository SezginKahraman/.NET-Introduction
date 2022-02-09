using System;
using System.Collections.Generic;

namespace kendiDenemelerim2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> musteriler = new List<string>();
            musteriler.Add("ahmet");
            Console.WriteLine(musteriler);
            MyList<string> harfler = new MyList<string>();
            Console.WriteLine(harfler);

        }
    }
    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length+1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _tempArray[i] = _array[i];
            }

            _array[_array.Length - 1] = item;


        }


    }





}
