using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Daily_Codes_From_14_June
{

    internal class OOPs_Concepts_Practice
    {
        static void Main(string[] args)
        {
            string ch;
            do
            {
                Console.WriteLine("Welcome to tax checking center \nEnter Your Account Balance");
                int balance = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Your Account Type('current' or 'saving')");
                string type = Console.ReadLine();
                CheckBalance check = new CheckBalance(balance, type);
                check.Checkbal();
                ch=Console.ReadLine();
            }   while (ch=="Yes" || ch=="yes");
            
            
        }
    }
    public class BankAccount
    {
        protected int balance;
        protected string type;
        public BankAccount(int balance,string type)
        {
            this.balance=balance;
            this.type = type;
        }


    }
    public class CheckBalance : BankAccount
    {
        public CheckBalance(int balance, string type) : base(balance, type)
        {
        }

        public void Checkbal()
        {
            if (type == "saving")
            {
                int sav_acc_bal = balance - (balance / 100) * 2;
                Console.WriteLine("Your saving account balance will be " + sav_acc_bal + " by diducting 2% tax");
            }
            else if (type == "current")
            {
                int sav_acc_bal = balance - (balance / 100) * 8;
                Console.WriteLine("Your Current account balance will be " + sav_acc_bal + " by diducting 8% tax");
            }
            else
            {
                Console.WriteLine("Invalid Input,Retry again..! \nDo You want to continue (Yes/No)");

            }

        } 
    }

}













//oops have four pillors abstraction inheritance polymorphism encapsulation
//inheritance is the process of creating derived class from base class it have multiple types- multiple inheritance(using interface) multilevel inheritance single level inheritance hirichical inheritance hybrid inheritance
//encapsulation is process of binding data together in single unit
//polymorphisum is greek word poly means many and morph means forms one task is performed in multiple ways that is polymophisum
//abstractions is way of showing functionality  to user and hide essential data 

/*
 
class Animals
        {
            //this is the example of encatsulations where we binded data in single unit data protection is here 
            string name;
            int age;
            public void SetName(string name)
            {
                this.name = name;
            }
            public void SetAge(int age)
            {
                this.age = age;
            }
            public int GetAge()
            {
                return this.age;
            }
            public string GetName()
            {
                return this.name;
            }
         
        }
        static void Main(string[] args)
        {
            Animals a= new Animals();
            a.SetName("Tiger");
            a.SetAge(10);
            Console.WriteLine(a.GetName()+" "+a.GetAge());
            Console.ReadLine();
        }
 
 */

/*
single level inheritance

static void Main(string[] args)
        {
            Console.WriteLine("Enter radious:");
            double a = double.Parse(Console.ReadLine());
            Circle c = new Circle(a);
            c.Area();
            Console.ReadLine();

        }

    }
    class Shape
    {
        int length;
       public double radious;
        Shape(int length)
        {
            this.length = length;
        }
        public Shape(double radious)
        {
            this.radious = radious;
        }
    }

    internal class Circle : Shape
    {
        public Circle(double radious) : base(radious)
        {
            this.radious=radious;
        }
       public double Area()
        {
            double area = Math.PI * radious * radious;
            Console.WriteLine("Area of circle is :" + area);
            return area;
        }

    }

 */

/*
single level inheritance
 public interface Drawable
    {     
         void draw();
    }

     public class Reactangle : Drawable
    {
        public void draw()
        {
        Console.WriteLine("drawing rectngle...");
    }
    }
}

 */

/*
 this is example of method overriding 
  static void Main(string[] args)
        {
            Car car = new Car();
            car.Run();
            SportCar sc = new SportCar();
            sc.Run();
            Console.ReadLine();
        }
    }

    class Car
    {
        public virtual void Run()
        {
            Console.WriteLine("Car is running...");
        }
    }
    class SportCar : Car
    {
        
        public override void Run()
        {
            Console.WriteLine("Sport Car is Running...");
        }
    }
    
 */