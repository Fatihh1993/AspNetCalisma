using System;

namespace _03.ActionDelegeler
{
    class Program
    {

        static void Main(string[] args)
        {

            Action action = new Action(SelamVer);


            action.Invoke();


            //Action<string> action2 = new Action<string>(SelamVer2);
            //action2 += SelamVer3;
            //action2.Invoke("Ahmet");

            Action<string> action2 = new Action<string>(name =>
            {

                Console.WriteLine("selam"+ name);


            });

            action2.Invoke("Fatih");


        
        }


        private static void SelamVer3(string name)

        {
            Console.WriteLine("Selam" + name+ "nasılsın");

        }   
        private static void SelamVer2(string name)

            { Console.WriteLine("Selam"+ name);
        }

        private static void SelamVer()
        {
         Console.WriteLine("Selam Fatih");
        }
    }
}
