using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class MethodOverloading
    {
        class Car
        {
            public virtual int add(int x, int y)
            {
                Console.WriteLine(x+y);
                return x + y;
            }
        }
        class smartcar:Car 
        {
            public override int add(int x,int y)
            {
                Console.WriteLine(x+y);
                return x + y;
            }
        }
        static void Main(string[] args)
        {
            smartcar car = new smartcar();
            car.add(2, 3);
        }

    }
}


/*
  float add(int x, int y)
            {
                Console.WriteLine(x + y);
                return x + y;
            }

             static void Main(string[] args)
            {
                Program p = new Program();
                p.add(1, 2);
                p.add(2.2f, 3.2f);
                Console.ReadLine();
 
 */