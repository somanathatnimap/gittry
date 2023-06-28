using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class MultThreading1
    {
        class program
        {
            public static object locker=new object();
            public static void Dowork()
            {
                // lock (locker)
                //  {
                try
                {

                    Monitor.Enter(locker);
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is running...");
                    Thread.Sleep(1000);
                    throw new Exception();
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is stopped...");
                   // Monitor.Exit(locker);
                    //}
                }
                catch(Exception e) { }
                finally { Monitor.Exit(locker); }
            }
            public static void Main(string[] args)
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread t = new Thread(Dowork);
                    t.Start();
                }
                Console.ReadLine();
            }
        }
    }
}
