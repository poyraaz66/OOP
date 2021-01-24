using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "Engin","Murat","Poyraz","Kerem","Halil" };
            isimler.Add("kerem");

            Console.WriteLine(isimler[5]);
        }
    }
}
