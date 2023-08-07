using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class DublicateNoInList
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 3, 4, 5, 1 };
            for(int i=0;i<arr.Length-1; i++)
            {
            bool IsDublicate = false;
                for(int j = i+1;j< arr.Length-1; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        IsDublicate=true;
                       break;
                    }
                }
                if (IsDublicate)
                {
                    Console.WriteLine(arr[i]);
                }
                
            }

            Console.ReadLine();
        }
    }
}
