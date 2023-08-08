using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class Pattern5
    {
        static void Main(string[] args)
        {
            string str = "soma";
            char[] ch = str.ToCharArray();
            char[] ch1 = new char[ch.Length];
            int position = 0;
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                ch1[position] = ch[i];
                Console.WriteLine(ch[i]);
                position++;
            }
            string str1=new string(ch1);
            Console.WriteLine(str1);
            Console.ReadLine();
        }
    }
    }

/*
 static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = i; j < j + 5; j++)
                {
                    Console.WriteLine(j);
                }
                Console.WriteLine("hi");
            }
        }
 */

/*
 public static void Main(string[] args)
    {
        int [] arr={1,2,3,4,5,6,7};
        int oddsize=0;
        int evensize=0;
       
        for(int i=0;i<arr.Length-1;i++)
        {
            if(i%2==0)
            {
                oddsize++;
            }
            else
            {
                evensize++;
            }
        }
        int [] odd=new int[oddsize];
        int [] even=new int[evensize];
        int forodd=0;
        int foreven=0;
       for(int i=0;i<arr.Length-1;i++)
        {
            if(i%2 == 0)
            {
                odd[forodd]=arr[i];
                forodd++;
            }
            else
            {
                even[foreven]=arr[i];
                foreven++;
            }
        }
        Console.WriteLine("this is array of odd ");
        foreach(int i in odd)
        {
            Console.WriteLine(i);
        }
         Console.WriteLine("this is array of even ");

        foreach(int i in even)
        {
            Console.WriteLine(i);
        }
    }
}
 */