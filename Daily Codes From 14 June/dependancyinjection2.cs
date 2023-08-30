using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class dependancyinjection2
    {
        //dependancy injection using property injection
        public interface IAccount
        {
            void Details();
        }
        public class CurrentAccount : IAccount
        {
            public void Details()
            {
                Console.WriteLine("Current Account");
            }
        }
        public class SavingAccount : IAccount
        {
            public void Details()
            {
                Console.WriteLine("Saving Account");
            }
        }
        public class Account
        {
            public IAccount account { get; set; }
            public void Details()
            {
                account.Details();
            }
        }
        static void Main(string[] args)
        {
            Account sa = new Account();
            sa.account = new SavingAccount();
            sa.Details();
            
            Account ca = new Account();
            ca.account = new CurrentAccount();
            ca.Details();
            Console.ReadLine();
        }
    }
}

