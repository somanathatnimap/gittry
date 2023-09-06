using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class ObjectList
    {
       
            public static void Main(string[] args)
            {
            for(int i = 1; i < 100; i++)
            {
            bool isPrime=true;
                for(int j=2;j< 100; j++)
                {
                    if (i % j == 0 && i!=j)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
        }
    }

