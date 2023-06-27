using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class OutRef
    {
        class Hello
        {
            static int Add(int x)
            { //pass by value
                x = x + 10;
                Console.WriteLine("pass by value"+x);
                return x;
            }
            static int Add1(ref int y)
            {
                y = y + 10;
                Console.WriteLine("pass by refrance "+y);
                return y;
            }
            //now out
            static void Add3(out  int z)
            {
                 z = 10;
                Console.WriteLine("pass by out"+z);
            }

            static void Main(string[] args)
            {   //pass by value
                //Hello hello = new Hello();
                int value = 5;
                Add(value);
                Console.WriteLine(value);

                int value1 = 5;
                Add1(ref value1);
                Console.WriteLine(value1);

                //pass by out
                int value2;
                Add3(out value2);
                Console.WriteLine(value2);
                Console.ReadLine();
            }
        }

    }
}
