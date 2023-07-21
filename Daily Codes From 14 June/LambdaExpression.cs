using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class LambdaExpression
    {
        delegate void Mydelegates(int a, int b);
        class Program
        {
                
            static void Main(string[] args)
            {

            }
        }
    }
}








/*
 Mydelegates de=delegate(int a,int b) 
                {
                    Console.WriteLine(a+b);
                };
                de.Invoke(10, 20);
                Console.ReadLine();
 */


/*
 
 static void addition(int a, int b)
            {
                Console.WriteLine(a+b);
            }
            static void substraction(int a, int b)
            {
                Console.WriteLine(a-b);
            }
            static void Main(string[] args)
            {
                mydelgate md=new mydelgate(Program.addition);
                //multicast delegates
                md += substraction;
                md -= addition;
                md.Invoke(12, 20);
                

 */
/*
 
static void Mymethod(int a, int b)
            {
                Console.WriteLine(a + b);
            }
            public static void Main(string[] args)
            {
                Mydelegates mydelegates = new Mydelegates(Program.Mymethod);
                mydelegates(2,3);
            }
 */