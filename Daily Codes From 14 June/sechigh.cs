using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class sechigh
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 5, 2, 6, 1, 9, 5 };
            int high = 0;
            int sechigh = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > high)
                {
                    sechigh = high;
                    high = arr[i];
                }
                else if (arr[i] > sechigh && arr[i] < high)
                {
                    sechigh = arr[i];
                }
            }
                Console.WriteLine(sechigh);
                Console.ReadKey();
            
        }
    }
}
