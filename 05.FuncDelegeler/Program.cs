using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FuncDelegeler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new() { "Yavuz", "İbrahim", "Berk" };


            //Func<string, bool> func = new(AyiBul);

           var aIcerenIsimler =  isimler.Where(AyiBul);
            Console.WriteLine("Hello World!");
        }

        static bool AyiBul(string arg)
        {
            return arg.Contains("a");
        }
    }
}
