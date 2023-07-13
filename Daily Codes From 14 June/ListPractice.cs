using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class ListPractice
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> list1 = new List<int>() { 6, 7, 8, 9, 10 };

            List<List<int>> list3 = new List<List<int>>();
            list3.Add(list);
            list3.Add(list1);

            foreach (List<int> l in list3)
            {
                Console.WriteLine("Inner List:");

                foreach (int number in l)
                {
                    Console.WriteLine(number);
                }
            }
            Console.ReadLine();
        }

    }
}






/*
 constuctor overloading in list
 
 class Program
        {
            List<int> list = new List<int>();
            public Program()
            {
                list.Add(0);
                list.Add(1);
                foreach (int i in list)
                {
                    
                Console.WriteLine(i);
                }
            }
            public Program(int count)
            {
                list.Add(9);
                foreach (int i in list)
                {

                Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {
           Program p = new Program();
            Program p1 = new Program(3);
            Console.ReadLine();
        }
    }
}
 
 */

/*
           //this is how we can add list in another list
           static void Main(string[] args)
           {
               List<int> list = new List<int> { 1, 2, 3, 4, 5 };
               List<int> list2 = new List<int>() { 11,22,33};

              // list2.InsertRange(list.Count-3 ,list);
              list2.AddRange(list);
               foreach (int item in list2)
               {
                   Console.WriteLine(item);
               }
               Console.ReadLine();
           }

       */

/*
 static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,3,4,5};
            var a=list.IndexOf(44);
            Console.WriteLine(a);
            Console.ReadLine();

bool a=list.Contains(1);
            Console.WriteLine(a);
        }
 */

/*
 
List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            int count = 0;
            for (int i=0; i<list.Count;i++ )
            {
                if (list[i] == 4 )
                {
                    count++;
                }


            }
            if(count == 1) {
                Console.WriteLine("present");
            }
            

            Console.ReadLine();
        }


 
 */
/*
 // int large = 0;
            //int small = 0;
            List<int> list1 = new List<int>();
            for(int i=0;i<list.Count; i++)
            {
                Console.WriteLine("list"+list[i]);
            }
            foreach (var item in list1)
            {
                Console.WriteLine(item);


            }
 */

/*
 static void Main(string[] args)
        {
            List<int> list = new List<int>() { 2, 3, 1, 5, 6, 4 };

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }

            foreach (int num in list)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();

        }
 */

/*
 List<int> list = new List<int>() { 1,2,3,4,5,6};
            int count=0;
            foreach (int i in list)
            {
                count++;
            }
            Console.WriteLine(count);
            Console.ReadLine();
 */

/*
  static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i] % 2==0)
                {

                    Console.WriteLine(list[i]);
                }

            }
            Console.ReadLine();
            
        }
 */
/*
  List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < list.Count; i++)
            {
                
                if (list[i] % 2 == 0)
                {
                    list.Remove(list[i]);

                }
                Console.WriteLine(list[i]);

            }
            Console.ReadLine();
 */

/*
 
 List<int> list1=new List<int>();
           List<int> list = new List<int>() { 1,2,3,4,5,6};
           
            for(int i=0;i<list.Count; i++)
            {
                list1.Add(list[i]);
            }

 */

/*
 List<int> list = new List<int>() { 1,2,3,4,5};
            int count = 0;
            for(int i=0;i<list.Count; i++)
            {
                count += list[i];
            }
            Console.WriteLine(count);
            Console.ReadLine();
 */

/*
           var duplicate = list.GroupBy(x => x).Where(y => y.Count() > 1)
               .Select(z =>z.Key).ToList();

           foreach ( var item in duplicate) 
           {
               Console.WriteLine(item);

           }
           Console.ReadLine();
               */

/*
 List<int> list=new List<int>() { 1, 2,2, 3, 4, 5, 1, 2, 6 };
            for (int i = 0; i < list.Count-1; i++)
            {
            int count = 1;
                for (int j = i+1; j < list.Count; j++)
                {
                    if (list[j] == list[i])
                    {
                        count++;
                        Console.WriteLine(list[j]+"count is "+count);
                    }
                }
            }
            //console.writeline(ans);
            Console.ReadLine();
 */
/*
  List<int> list = new List<int>();
            bool run = true;
            Console.WriteLine("Add Numbers (Add 0 when yo're done):");
            while (run==true)
            {
                int num=int.Parse(Console.ReadLine());
                list.Add(num);
                if (num == 0)
                {
                    run = false;
                }
            }
            Console.WriteLine("your list is");
            foreach (int num in list)
            {
                Console.WriteLine(num);
            }
            
            Console.ReadLine();
 */