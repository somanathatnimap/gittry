using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class EinumvsEinum
    {
        class IEnumerablevsIEnumerator
        {
            static void Main(string[] args)
            {
                List<int> list = new List<int>();
                list.Add(1910);
                list.Add(1920);
                list.Add(1930);
                list.Add(1940);
                list.Add(1950);
                list.Add(1960);
                //this is ienumerable
                IEnumerable<int> values=(IEnumerable<int>)list;
                foreach(int value in values)
                {
                    Console.WriteLine(value);
                }
                //this is ienumerator
                IEnumerator<int> enumerator = list.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current.ToString());
                }

                //boxing and unboxing
                int num = 10;
                object obj = num;//implicit conversion of value type into reference type
                
                object obj2 = 20;
                int val=(int)obj;//unboxing

                Console.ReadLine();

            }
           

        }
    }
}
