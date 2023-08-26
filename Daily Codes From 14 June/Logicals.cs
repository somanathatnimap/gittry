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
       
    }
}

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
 
 */