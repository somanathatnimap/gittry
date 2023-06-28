using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class MultiThreading2
    {
        class Program
        {
            static AutoResetEvent au=new AutoResetEvent(true);
            static ManualResetEvent m_event = new ManualResetEvent(false);
            public static void writting()
            {
                Console.WriteLine($"This thread is No {Thread.CurrentThread.ManagedThreadId} waiting..!");
                au.WaitOne();

                Console.WriteLine($"This thread is No {Thread.CurrentThread.ManagedThreadId} Writing..." );
                m_event.Reset();
                Thread.Sleep(1000);
                Console.WriteLine($"This thread is No {Thread.CurrentThread.ManagedThreadId} Writting completed...");
                m_event.Set();
                au.Reset();
            }
            public static void Reading()
            {
                Console.WriteLine($"This thread is No {Thread.CurrentThread.ManagedThreadId} Reading...");
                m_event.WaitOne();
                Thread.Sleep(1000);
                Console.WriteLine($"This thread is No {Thread.CurrentThread.ManagedThreadId} Reading completed..."); 
                m_event.Reset();
            }

            static void Main(string[] args)
            {
                new Thread(writting).Start();
                for (int i = 0; i < 5; i++)
                {
                Thread t1 = new Thread(Reading);
                t1.Start();

                }

                Console.ReadLine();
            }
        }
    }
}
