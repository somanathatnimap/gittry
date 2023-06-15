using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class Abstract_Class
    {
        abstract class Person
        {
            public string Name;
            public int age;
            public long mobile;
            public int phone;

            public abstract void printDetails();
            
        }
        class Student : Person
        {
            public int rollno;
            public override void printDetails()
            {
                
                string name = this.Name;
                int age = this.age;
                
                long mobile = this.mobile;
                int rollno = this.rollno;

                Console.WriteLine(name + " " + age+" "+mobile+" "+rollno);
            }
        }
        class Teacher : Person
        {
            public string qulification;
            public int salary;

            public override void printDetails()
            {
                string name = this.Name;
                int age = this.age;
                long mobile = this.mobile;
                string qulification=this.qulification;
                int salary=this.salary;

                Console.WriteLine(name + " " + age + " " + mobile + " " + qulification + " " + salary);
            }

        }
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Somanath";
            student.age = 21;
            student.mobile = 9989093733;
            student.rollno = 50;
            student.printDetails();
            
            Teacher teacher = new Teacher();
            teacher.Name = "Dipali Karche";
            teacher.mobile = 9898877667;
            teacher.age = 32;
            teacher.salary = 400000;
            teacher.qulification = "MTECH";
            teacher.printDetails();

            Console.ReadLine();
        }
    }
}
