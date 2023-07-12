using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class LinqExp
    {
        class Program
        {

            static void Main(string[] args)
            {
                int[] arr = { 1, 2, 3, 4, 5 };
                // var a = from i in arr orderby i descending select i;
                //var a= from i in arr where arr.Contains(2) select arr;
                String[] arr1 = { "soma", "viraj", "vivek", "gaurav", "omkar" };
                // var a=from i in arr from j in arr1 select new {i,j};

                foreach (var i in arr)
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();

            }

        }
    }
}