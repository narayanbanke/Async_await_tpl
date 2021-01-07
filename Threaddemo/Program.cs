using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threaddemo
{
    class Program
    {
        static void Main(string[] args)
        {
            function1();
            function2();
            Console.ReadLine(); 
        }

        private static  void function1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("function1 is executed" + " " + i);
            }
        }

        private static void function2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("function1 is executed" + " " + i);
            }
        }
    }
}
