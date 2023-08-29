using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class Logicals
    {
        public Logicals(out int i) 
        {
             i = 12;
            Console.WriteLine(i);
        }
        public Logicals(out int i,string str)
        {
            i = 122;
            Console.WriteLine(i);
        }
        public static void Main(string[] args)
        {
            int i;
            Logicals logicals = new Logicals(out i);
            Console.WriteLine(i);
            string str = "soma";
            Logicals logicals1 = new Logicals(out i,str);

            Console.ReadLine();
        }
        /*
        public void Hello(ref int i)
        {
            i=i+1;
            Console.WriteLine(i);
        }
        public static void Main(string[] args)
        {
            int i= 0;
            Logicals hw = new Logicals();
            hw.Hello(ref i);
            Console.WriteLine(i);
            // Console.WriteLine ();
            Console.ReadLine();
        }
        */
    }
}


/*
 
{


            for (int i = 2; i < 100; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < 100; j++)
                {
                    if (i % j != 0 && i != j)
                    {

                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string str="Hello World";
        char ch;
        string rev="";
       // for(int i=str.Length-1;i>=0;i--)
      // foreach(char i in str)
      int i=str.Length-1;
      while(i>=0)
        {
            ch=str[i];
            rev=rev+ch;
            i--;
        }
        Console.WriteLine (rev);
    }
}

 */

/*
 // Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int [] arr={1,2,3,4,5,6};
        int evencount=0;
        int oddcount=0;
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]%2==0){
                evencount++;
            }
            else{
                oddcount++;
            }
        }
        int [] odd=new int[oddcount];
        int [] even=new int[evencount];
          Console.WriteLine(oddcount);
          Console.WriteLine(evencount);
             int eveni=0;
            int oddi=0;
        for(int i=0;i<arr.Length;i++)
        {
         if(arr[i]%2==0){
                even[eveni]=arr[i];
                Console.WriteLine("even is"+even[eveni]);
                eveni++;
                }
            else{
              odd[oddi]=arr[i];
                Console.WriteLine("Odd is"+odd[oddi]);

              oddi++;
            }
        }
          
           
        }
       
    }



/*
for(int i=0;i<arr.Length;i++)
        {
            for(int j=0;j<=i;j++){
            if(arr[i]%2==0){
                          Console.WriteLine(arr[i]);

              //  arr[i]=even[j];
                }
            else{
                          Console.WriteLine(arr[i]);

             //   arr[i]=odd[j];
            }
            }
*/



/*
 
class fibbonocy
        {
            static void Main(string[] args)
            {
                int num = 7;
                int a = 0;
                int b = 1;
                int sum = 0;
                for(int i=0;i<100;i++)
                {
                    sum = a + b;
                    b = a;
                    a = sum;
                    if (num > sum && sum>0)
                    {

                    Console.WriteLine(sum);
                    }
                }
                Console.ReadLine();
            }
        }
    }

 static void Main(string[] args)
        {
            string str = "abcd";
            char ch;
            string rev = "";
            for(int i=0;i<str.Length; i++)
            {
                ch = str[i];
                rev = ch + rev;
            }
            Console.WriteLine(rev);
            Console.ReadLine();
        }



public static void Main(string[] args)
        {
            int[] arr = { 2, 4, 2, 6, 8, 4, 9, 4 };
            int highest = 0;
            int sechighest = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > highest)
                {
                    sechighest = highest;
                    highest = arr[i];
                }
                else if (arr[i] < highest && arr[i] > sechighest)
                {
                   // sechighest = arr[i];
                   // Console.WriteLine(arr[i]);
                }

            }
             Console.WriteLine(sechighest);
            Console.ReadLine();
        }
 
 */