using System;

namespace _03.ActionDelegeler
{
    class Program
    {
        // func, action ,predicate
        static void Main(string[] args)
        {
            Action action = new Action(()=> {
                Console.WriteLine("Selam");
            });

            action.Invoke();
            //action.Invoke();


            //Action<string> action2 = new Action<string>(SelamVer2);
            //action2 += SelamVer3;
            //action2.Invoke("Selim");

            Action<string> action2 = new Action<string>(name =>
             {
                 Console.WriteLine("Selam "+name);
             });

            action2.Invoke("Yavuz");


        }

        private static void SelamVer2(string name)
        {
            Console.WriteLine("Selam "+name);
        }

        private static void SelamVer3(string name)
        {
            Console.WriteLine("Selam " + name +" Nasılsın?");
        }


        private static void SelamVer()
        {
            Console.WriteLine("Selam Yavuz");
        }
    }
}
