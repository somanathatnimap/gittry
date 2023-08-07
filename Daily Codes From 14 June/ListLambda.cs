using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class ListLambda
    {
        static void Main(string[] args)
        {
           List<int> li = new List<int>{1,2,3,4,5,6,7};
            li.RemoveAll(x => x % 2 == 0);
            foreach (int x in li)
            {
                Console.WriteLine(x);
            }
            try
            {
                ArrayList l = new ArrayList();
                l.Add(1);
                l.Add("3");
                l.Add(2.0);
                l.Add(l.Count);

                foreach (int x in l)
                {
                    Console.WriteLine("ArrrayList" + x);
                }
            }
            catch { Exception exception; }

            Console.ReadLine();

        }
       
        
    }
}
