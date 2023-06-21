using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialExp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartialExample example = new PartialExample();
            example.add(12, 23);
            example.add(12, 29);
            example.sub(100, 25);
            Console.ReadLine();
        }
    }
}
