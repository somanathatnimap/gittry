using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class PatternPrinting
    {
        static void Main(string[] args)
        {
            for(int i=0;i<5;i++)
            {
                for(int j = 5; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }Console.ReadLine();
        }
    }
}
