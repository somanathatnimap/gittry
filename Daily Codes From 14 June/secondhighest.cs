using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class secondhighest
    {
        class secondhight
        {
            static void Main(string[] args)
            {
                int[] arr = { 12, 35, 1, 10, 34, 1, 35 };
                int largest = 0;
                int secondlargest = 0;
                foreach (int i in arr)
                {
                    if (i > largest)
                    {
                        secondlargest = largest;
                        largest = i;
                    }
                    else if(largest > i && secondlargest<i)
                    {
                        secondlargest = i;
                    }
                }
                    Console.WriteLine(secondlargest);
                Console.ReadLine();
            }
        }
    }
}
