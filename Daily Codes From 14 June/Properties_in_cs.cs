using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Daily_Codes_From_14_June
{
    internal class Properties_in_cs
    {
        class newtwo
        {
           public string name { get;set; }
            public newtwo(string name) 
            {
                this.name = name;
            }
        }
        class newone
        {
            private int id;
            private string name;
            private string fname = "NoName";
            public string fullname { get; set; }

            public int _fname
            {
                set
                {
                    this._fname = value;
                }
            }
            public string sname
            {
                get { return name; } 
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("Anonynmus Name");
                        name = "Anynonomus";
                    }
                    else
                    {

                    name = value;
                    }
                }
            }
            public int sid
            {
                get
                {
                    return id;
                }
                set
                {
                    /*if (value == null)
                    {
                        Console.WriteLine("Null Value");
                    }*/
                    if (value < 0) 
                    {
                        Console.WriteLine("id cannot be zero");
                    }

                    else
                    {

                    id = value;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
                newtwo t = new newtwo("somanath");
                t.name = "soma";
                Console.WriteLine(t.name);


                newone  o=new newone();
            Console.WriteLine("Enter id and name");
            o.sid = Convert.ToInt32(Console.ReadLine());
            o.sname = Convert.ToString(Console.ReadLine());
            o.fullname=Convert.ToString(Console.ReadLine());
            Console.WriteLine(o.sid);
            Console.WriteLine(o.sname);
            Console.WriteLine(o.fullname);
            Console.ReadLine();
        }

    }
}
