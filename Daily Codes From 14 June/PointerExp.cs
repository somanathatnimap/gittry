using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class PointerExp
    {
        class Program
        {
         
           unsafe static void Main(string[] args)
            {
                int a = 10;
                int* pointer = &a;
                Console.WriteLine(*pointer);
                Console.ReadLine();
            }
        }
    }
}
