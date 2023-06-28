using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class MultiThreading
    {
        class Main1
        {
            public  void func1()
            {
                lock (this)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine("Function 1 :" + i);
                    }
                }
                
                
            }
            public static void func2()
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Function 2 :" + i);
                    
                }
            }
            public static void func3()
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Function 3 :" + i);
                }
            }
            static void Main(string[] args)
            {
                /*
                //this is by default thread it is Main thread
                Thread t = Thread.CurrentThread;
                t.Name = "First Thread";
                Console.WriteLine(Thread.CurrentThread.Name);
                Console.ReadLine();
                */
                Main1 m=new Main1();
              
                    Thread t = new Thread(m.func1);
                    t.Start();

                Thread t2=new Thread(func2);
                t2.Start();
                Thread t3=new Thread(func3);
                t3.Start();
                Console.ReadLine();

            }
        }
    }
}
