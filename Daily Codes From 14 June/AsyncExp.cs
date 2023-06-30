using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class AsyncExp
    {
        class Program
        {
            static void Run1()
            {
                Console.WriteLine("First Method is Running...");
                Console.WriteLine("First Method is Completed");
            }
            static void Run2()
            {
                Console.WriteLine("Second Method is Running...");
                Console.WriteLine("Second Method is Completed");
            }
            static void Run3()
            {
                Console.WriteLine("Third Method is Runnning...");
                Console.WriteLine("Third Method is Completed");

            }
            static void Main(string[] args)
            {
                Run1();
                Run2();
                Run3();
                Console.ReadLine();
            }
        }
    }
}
