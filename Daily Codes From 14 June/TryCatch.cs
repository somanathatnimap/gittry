using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class TryCatch
    {

        static void Main(string[] args)
        {
            try
            {

                int a = 10;
                int b = 0;
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException)
            { }

            Console.ReadLine();

        }
    }
}
 