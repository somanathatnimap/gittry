using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
   internal class OpratorOverloading
    {
        /*
        class NewClass
        {
            public int num;
            public string str;
            
        }
        static void Main(string[] args)
            {
                NewClass n1 = new NewClass();
                n1.str = "Soma";
                n1.num = 1;

                NewClass n2 = new NewClass();
                n2.str = "Raj";
                n2.num = 2;

                NewClass n3 = new NewClass();
                n3.str = n1.str + n2.str;
                n3.num = n1.num + n2.num;
            Console.WriteLine(n3.str);
            Console.ReadLine(); */

        /* constructor overloading 
        public class ConstructorOverloading
        {
            int id;
            string name;
            public ConstructorOverloading()
            {

            }
            public ConstructorOverloading(int id,string name)
            {
            this.id = id;
            this.name = name;
            }
            public ConstructorOverloading(int id) 
            {
                this.id=id;
            }
            static void Main(string[] args)
            {
                ConstructorOverloading co = new ConstructorOverloading();
            }
        }
        */

            //Console.WriteLine("soma");
            //Console.ReadLine();
         
            
            /*  Stopwatch stopwatch = new Stopwatch();
              Console.ReadLine();
                  stopwatch.Start();
                  Console.WriteLine(stopwatch.Elapsed.ToString());
                  Console.ReadLine();
              */
            /*
            StringBuilder sb = new StringBuilder();
              sb.Append("Hi");
              sb.Append(" I'm");
              Console.WriteLine(sb);
              Console.ReadLine();
            */
            /*
            Stack<string> books = new Stack<string>();
            books.Push("No1");
            */
            /*
        class MethoD
        {
            int a;
            int b;
            int c;
            public int m1(int a,int b)
            {
                this.a=a;
                this.b = b;
                this.c = a + b;
                Console.WriteLine(c);

                return c;
            }
            public int m1(int a,int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                Console.WriteLine(a+b+c);
                return 0;
            }
        }
        static void Main(String[] args)
        {
            MethoD m = new MethoD();
            m.m1(1, 2, 3);
        }
            */
          
            static void Main(string[] args)
            {
                Queue<int> values = new Queue<int>();
                values.Enqueue(1);
                values.Enqueue(2);
                values.Enqueue(3);
                values.Dequeue();
                foreach(int i in values)
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();

            }
        }
        }
        
        
        


