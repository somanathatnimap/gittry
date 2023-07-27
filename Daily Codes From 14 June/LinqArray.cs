using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Daily_Codes_From_14_June.Lambada_Expression;

namespace Daily_Codes_From_14_June
{
    public class LinqArray
    {
        public class Programm
    {
        public delegate int MyDelegate(int[] x);
        public void Example()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            var largest = arr.Where(x => x == arr.Max()).First();
            Console.WriteLine(largest);
        }
    }

         static void Main(string[] args)
        {
            {
                MyDelegate mydel = delegate (int a)
                 {
                     Programm p = new Programm();
                     p.Example();
                 };
                Console.ReadLine();
            }
        }
    }
}
