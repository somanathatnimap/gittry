using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class TwoSumLeetCode
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 3, 2, 4 };
            List<int> output= new List<int>();
            int num = 6;
            for(int i=0; i<list.Count-1; i++)
            {
                for(int j=i+1; j<list.Count;j++)
                {
                    if (list[i] + list[j] == num)
                    {
                        output.Add(i);
                        output.Add(j);
                    }
                }
            }
           foreach(int i in output)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
