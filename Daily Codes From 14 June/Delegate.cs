using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class Delegate
    {
        public delegate void myName(string name);

        class myDelegate
        {
            public void myOrigin(string n)
            {
                Console.WriteLine(n);
            }
        }

        static void Main(string[] args)
        {
            myName myDelegate = new myName(new myDelegate().myOrigin);
            myDelegate("Somanath Barge");

            myName n = delegate(string a) 
            {
                Console.WriteLine(a);
            };
            //anonymous
            n.Invoke("hello");
            Console.ReadLine();

        }
    }
}
