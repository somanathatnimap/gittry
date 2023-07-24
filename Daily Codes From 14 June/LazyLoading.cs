using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class LazyLoading
    {

class Program
    {
        static void Main()
        {
            Lazy<ExpensiveObject> lazyObject = new Lazy<ExpensiveObject>(() => new ExpensiveObject());
            ExpensiveObject obj = lazyObject.Value;
            ExpensiveObject obj2 = lazyObject.Value;
                Console.ReadLine(); 
        }
    }

    class ExpensiveObject
    {
        public ExpensiveObject()
        {
            Console.WriteLine("ExpensiveObject is being initialized.");
        }
    }

}
}
