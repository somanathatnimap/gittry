using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class IEnumerable_Demo
    {
        class Program
        { /*
            public int id { get; set; }
            public string name { get; set; }

            
            class Code:IEnumerable
            {
                List<Students> students=new List<Students>();
                public void Code1(Students s)
                {
                    students.Add(s);
                }

                public IEnumerator GetEnumerator()
                {
                    return students.GetEnumerator();
                }
            }
            class Program {

                static void Main(string[] args)
                {

                    Students students = new Students();
                    students.id=1;
                    students.name="Soma";

                    Students students1 = new Students();
                    students1.id=2;
                    students1.name="Viraj";

                    Code students2 = new Code();
                    students2.Code1(students);
                    students2.Code1(students1);

                    foreach (Students stud in students2)
                    {
                        Console.WriteLine(stud.id+" " + stud.name);
                    }
                    Console.ReadLine();
            */


            static void Main(string[] args)
            {
                List<int> num = new List<int>() { 11, 22, 33, 44, 55, 66, 77 };
                /* var numb = from i in num where i > 30 select i;
                 foreach (var i in numb)
                 {
                     Console.WriteLine(i);
                 }
                 Console.ReadLine(); */

                IEnumerator<int> iter = num.GetEnumerator();
                while (iter.MoveNext())
                {
                    Console.WriteLine(iter.Current);
                }
                Console.ReadLine();

            }
        }
    }


}
