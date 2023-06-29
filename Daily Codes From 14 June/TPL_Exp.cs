using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class TPL_Exp
    {
        class program
        {
            static void LoopEx()
            {
                for(int i = 0; i < 1000; i++)
                {
                    //string x = "";
                    Console.WriteLine(i);
                }

            Console.ReadLine();
            }
            static void Main()
            {
                Parallel.For(0, 10, x => LoopEx());
                
            }
        }
    }
}

