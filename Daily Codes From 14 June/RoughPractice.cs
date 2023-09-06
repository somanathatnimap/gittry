using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class RoughPractice
    {
        public int sum(ref int x)
        {
            x = x + 1;
            return x;
        }
        public int rum(out int x)
        {
            x = 22;
            return x;
        }
        static void Main(string[] args)
        {
          RoughPractice roughPractice = new RoughPractice();
            int a;
            roughPractice.sum(ref a);

            roughPractice.rum(out a);
            Console.ReadLine();
        }
    }
    }


/*
 class Hello
        {
            private string name { get; set; }
            public Hello(string Name)
            {
                this.name=Name;
                Console.WriteLine(name);

            }
        }
        static void Main(string[] args)
        {
            Hello hello = new Hello("SOma");
            Console.ReadLine();
        }

int a = 10;
            Console.WriteLine($"{a*a}");

List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            int a=list.Find(x=>x.Equals(1));
            Console.WriteLine(a);
            Console.ReadLine();

public delegate int add(int a, int b);
        public int sum(int x,int y)
        {
            return x + y;
        }
       static void Main(string[] args)
        {
            RoughPractice ro=new RoughPractice();
            add a = new add(ro.sum);

        }

  int[] arr = { 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> show = arr.Select(x => x).ToArray();
            Console.WriteLine(show);
            Console.ReadLine();

public int sum(ref int x)
        {
            x = x + 1;
            return x;
        }
        static void Main(string[] args)
        {
          RoughPractice roughPractice = new RoughPractice();
            int a = 10;
            roughPractice.sum(ref a);
            Console.ReadLine();
        }
 */