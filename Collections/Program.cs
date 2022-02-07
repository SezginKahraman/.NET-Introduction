using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<string> isimler2 = new List<string>{"ahmet"};
            //isimler2[0] = "ahmet";
            //veya  List<string> isimler2 = new List<string>{"ahmet, vb..."};
            isimler2.Add("mehmet");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);

        }
    }
}
