using System;
using System.Collections.Generic;

namespace _04.PredicateDelegeler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Predicate<string> predicate = new Predicate<string>(YavuzuBul);

            //var gelenData =  predicate.Invoke("Yavuz");

            List<string> isimler = new() {  "Ahmet","Ayşe","Tuğba","Serkan","Fatih", "Yavuz"};

            var bulunanIsim= isimler.Find(a=>a=="Yavuz");

            Console.WriteLine("Hello World!");
        }

        //private static bool YavuzuBul(string obj)
        //{
        //    return obj == "Yavuz";
        //}
    }
}
