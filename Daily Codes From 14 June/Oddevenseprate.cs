using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class Oddevenseprate
    {
        static void Main(string []args)
        {
            List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0; i < num.Count; i++)
            {
                if (num[i]%2 == 0)
                {
                    even.Add(num[i]);
                    Console.WriteLine(i);
                }
                else
                {
                    odd.Add(num[i]);
                }
            }
            foreach(int  i in odd)
            {

            Console.WriteLine("Odd list"+i);
            }
            foreach (int i in even)
            {

                Console.WriteLine("Even list" +i);
            }
            Console.ReadKey();
        }
    }
}
