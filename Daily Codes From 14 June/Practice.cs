using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class Practice
    {
        class Profile
        {
            protected int id;
           public void Set(int id)
            {
                this.id = id;
            }
            public void Get()
            {
                Console.WriteLine("id :"+id);
            }
        }
        class Pr : Profile
        {
            public string name;
            public void Set(string name)
            {
                this.name=name;
            }
            public void Gett()
            {
                Console.WriteLine("name :"+name);
            }


        }
        static void Main(string[] args)
        {
            
            Pr p=new Pr();  
            p.Set(1);
            p.Get();
            Console.ReadLine();
        }
    }
}