using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class Class3
    {
        interface Employee
        {
            void EmployeeDetails();
        }
        interface Person
        {
            void EmployeeDetails();
        }
        class Manager : Employee, Person  
        {
              void Employee.EmployeeDetails()
            {
                Console.WriteLine("This is interface..!");                
            }
             void Person.EmployeeDetails() {
                Console.WriteLine("This is also interface..!");
            }
        }
        public static void Main(string[] args)
        {
            Manager m= new Manager();
            ((Employee)m).EmployeeDetails();
                Console.ReadLine();
            
        }
    }
}
