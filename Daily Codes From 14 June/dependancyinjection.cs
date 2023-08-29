using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class dependancyinjection
    {  //this is example of tight coupling 
        public class SavingAccount
        {
            public void Balance()
            {
                Console.WriteLine("Saving Account Balance");
            }
        }
        public class CurrentAccount
        {
            public void Balance()
            {
                Console.WriteLine("Current Account Balance");
            }
        }
        class Account
        {
            public void Details()
            {
                CurrentAccount ca=new CurrentAccount();
                SavingAccount sa=new SavingAccount();

                ca.Balance();
                sa.Balance();
            }
        }

        static void Main(string[] args)
        {
            Account account = new Account();
            account.Details();
            Console.ReadLine();
        }
    }
}
