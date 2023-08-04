using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class ReverseNo
    {
        static void Main(string[] args)
        {
        int a= 123;
        int temp = 0;
        int rev = 0;
         
            while(a>0)
            {
                temp = a % 10;
                rev=(rev*10)+temp;
                a=a/10;
            }
                Console.WriteLine(rev);
            Console.ReadLine();
        }
    }
}
