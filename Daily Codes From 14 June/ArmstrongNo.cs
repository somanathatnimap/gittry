using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class ArmstrongNo
    {
        class Program
        {
            static void Main(string[] args)
            {
            int i = 371;
                int b = i;
                int rev = 0;
                int temp = 0;
                int cube = 0;
                while (i > 0)
                {
                    temp = i % 10;
                    cube=cube+(temp*temp*temp);
                    rev = (rev * 10) + temp;
                    i=i/ 10;
                }
                if (b == cube)
                {
                    Console.WriteLine("This is armstrong number"+cube);
                }
                Console.ReadLine();
            }
        }
    }
}
