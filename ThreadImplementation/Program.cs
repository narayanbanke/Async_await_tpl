using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadImplementation
{
    class Program
    {
      
            static void Main(string[] args)
            {
            Thread Thread1 = new Thread(function1);//signature of calling a function using thread
            
            Thread1.Start();

            Thread Thread2 = new Thread(function2);
            Thread2.Start();
            Console.ReadLine();
            }

            private static void function1()
            {
                for (int i = 0; i < 10; i++)
                {
                Console.WriteLine("function1 is executed" + " " + i);
              Thread.Sleep(4000);
                }
            }

            private static void function2()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("function2 is executed" + " " + i);
              Thread.Sleep(4000);
            }
            }
        }
    }
 
