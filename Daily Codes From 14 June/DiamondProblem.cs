using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class DiamondProblem
    {
        interface IProblem
        {
            void Show();
        }
        interface JProblem
        {
            void Show();
        }
        class Problem
        {
            public void show()
            {
                Console.WriteLine("This is example of diamond problem");

            }

        }
      

            static void Main(string[] args)
            {
                Problem problem = new Problem();
                problem.show();
            Console.ReadLine();
            }
        
    }
}

