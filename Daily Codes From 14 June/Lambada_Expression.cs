using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class Lambada_Expression
    {
        public delegate void MyDelegate(int a);

        static void Main(string[] args)
        {
            MyDelegate my = delegate (int b)
            {
                Console.WriteLine();
            };
            my.Invoke(10);
            Console.ReadLine();
        }
    }
}
