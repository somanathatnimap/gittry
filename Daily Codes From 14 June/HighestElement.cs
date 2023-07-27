using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class HighestElement
    {
        class Program
        {
            static void Main(string[] args)
            {
                int largest = 0;
                int[] arr = { 1, 2, 3, 5, 6, 33,22 };
                for(int i=0;i<arr.Length; i++)
                {
                    for(int j = 1; j < arr.Length; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            largest = arr[j];
                            //Console.WriteLine(largest);
                        }
                    }
                }
                Console.WriteLine(largest);
                Console.ReadLine();
            }
        }
    }
}
