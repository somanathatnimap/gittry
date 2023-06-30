using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class MethodHiding
    {
        class BaseClass
        {
            public void Method()
            {
                Console.WriteLine("This is method in Base Class");
            }
        }
        //method hiding also known as encapsulation
        class DerivedClass : BaseClass
        {
            public new void Method()
            {
                Console.WriteLine("This is method from Derived Class");
            }

        }
        static void Main(string[] args)
        {
            BaseClass b = new BaseClass();
            b.Method();
            DerivedClass d = new DerivedClass();
            d.Method();
            Console.ReadLine();
        }
    }
}
