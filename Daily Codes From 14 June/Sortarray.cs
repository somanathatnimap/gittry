using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class Sortarray
    {
        public class Program{

        static void Main(string[] args)
        {
            int temp = 0;
            int[] arr = new int[]{ 3, 2, 5, 8, 3, 1, 6, 1 };
            for (int i = 0; i <= arr.Length-1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                }
            }
            foreach(int i in arr)
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }
            
    }
    }
}
