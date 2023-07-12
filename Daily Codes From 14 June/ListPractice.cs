using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class ListPractice
    { //How do you create an empty list in C#
        static void Main(string[] args)
        {
        List<string> list=new List<string> { "Gaurav"};
            foreach (string s in list) 
            {

            Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
