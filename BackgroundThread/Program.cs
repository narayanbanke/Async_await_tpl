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
            Thread Thread1 = new Thread(function1);//foreground thread bydefault     
            Thread1.IsBackground = true;//background thread
            Thread1.Start();
            Console.WriteLine("main thread has gone"  );
            Console.ReadLine();
        }

        private static void function1()
        {
            
            Console.WriteLine("function1 is entered");
            Console.ReadLine();
            Thread.Sleep(3000);
            Console.WriteLine("child  thread has existed");
            Console.ReadLine();
        }

        
    }
}
 
