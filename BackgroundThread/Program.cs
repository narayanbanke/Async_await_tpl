using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackgroundThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread Thread1 = new Thread(function1);
            Thread1.IsBackground = true;
            Thread1.Start();
            Console.WriteLine("main thread has existed"  );
            Console.ReadLine();
        }

        private static void function1()
        {
            
                Console.WriteLine("function1 is entered");
            Console.ReadLine();
            Console.WriteLine("child  thread has existed");
        }

        
    }
}
 
