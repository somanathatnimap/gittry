using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class All_Concepts
    {




        /*
        public static void Main(string[] args)
        {

        string s1 = "soma";
        char[] chars = s1.ToCharArray();
        Array.Reverse(chars);
            Console.WriteLine(chars);
            Console.ReadLine();
        }
        */

        /*
        static void Main(string [] args)
        {
        int a;
            Func<int,int, int,int> Add=(x,y,z)=>x+y+z;
            Console.WriteLine(Add(1,2,3));

            IEnumerable<int> list = new List<int>() { 1,2,3,4};
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
          void  add(out a);

            Console.WriteLine(a);
            
            

            Console.ReadLine();

        }
       public void add(out a)
        {
            a = 10;
        }
            */

        /*
         
         int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Create a Task to process the numbers in parallel
        Task[] tasks = new Task[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            int num = numbers[i];
            tasks[i] = Task.Run(() => ProcessNumber(num));
        }

        // Wait for all tasks to complete
        Task.WaitAll(tasks);

        Console.WriteLine("All tasks are completed.");
    }

    static void ProcessNumber(int num)
    {
        // Simulate some processing time
        Thread.Sleep(1000);
        Console.WriteLine($"Processed number: {num}, Thread ID: {Thread.CurrentThread.ManagedThreadId}");
    }
}


         */

        /*
        class Program
        {
            static async Task Main()
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                var tasks = ProcessNumbersAsync(numbers);

                await Task.WhenAll(tasks);

                Console.WriteLine("All tasks are completed.");
            }

            static async Task ProcessNumbersAsync(int[] numbers)
            {
                foreach (int num in numbers)
                {
                    await ProcessNumberAsync(num);
                }
            }

            static async Task ProcessNumberAsync(int num)
            {
                await Task.Delay(1000);
                Console.WriteLine($"Processed number: {num}, Thread ID: {Environment.CurrentManagedThreadId}");
            }
     
        }
        */
    }
}
