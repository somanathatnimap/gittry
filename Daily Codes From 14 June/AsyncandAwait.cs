using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class AsyncandAwait
    {
        class Program
        {
            public static async void Run1() 
                
            {
                await Task.Run(() =>
                {
                    Console.WriteLine("First Method is Running...");
                    Thread.Sleep(4000);
                    Console.WriteLine("First Method is Completed");
                });
                
            }
            public static async void Run2()
            {
                await Task.Run(() => {
                    Console.WriteLine("Second Method is Running...");
                    Thread.Sleep(4000);
                    Console.WriteLine("Second Method is Completed");
                });
                 Console.Out.WriteLine("hello");

            }
            public static async void Run3()
            {
                await Task.Run(() => {
                    Console.WriteLine("Third Method is Runnning...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Third Method is Completed");

                });


            }
            public static async void Run4()
            {
                await Task.Run(() =>{
                    Console.WriteLine("Fourth Method is Runnning...");
                    Thread.Sleep(1000);
                    Console.WriteLine("Fourth Method is Completed");

                });
                }
            static void Main(string[] args)
            {
                Run1();
                Run2();
                Run3();
                Run4();
                Console.ReadLine();
            }
        }
    }
}
