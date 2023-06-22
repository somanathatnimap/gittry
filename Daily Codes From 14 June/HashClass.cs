using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class HashClass
    {
        public static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable()
            {
                { "Id",1},{"Name","Somanath"},{"Sal",10000},{"Dept","Btech"}
            };
            foreach(object key in  hashtable.Keys)
            {
                Console.WriteLine(key+" :"+hashtable[key]);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine(hashtable.Contains("Id"));
            Console.WriteLine(hashtable.GetHashCode());
            hashtable.Remove("Id");

            foreach(object key in hashtable.Keys)
            {
                Console.WriteLine(key+" " + hashtable[key]);
            }

            Console.ReadLine();
        }
    }
}

