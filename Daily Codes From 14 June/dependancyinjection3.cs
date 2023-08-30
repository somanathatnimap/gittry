using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class dependancyinjection3
    {
        public interface IAccount
        {
             void Details();
        }
        class CurrentAccount:IAccount
        {
            public void Details()
            {
                Console.WriteLine("Current account details");
            }
        }
        class SavingAccount : IAccount
        {
            public void Details()
            {
                Console.WriteLine("Saving account details");
            }
        }
        class Account
        {
            public IAccount account;
            public void ADetails(IAccount account)
            {
                account.Details();
            }
        }
        static void Main(string[] args)
        {
            Account account = new Account();
            IAccount sa=new SavingAccount();
           // sa.Details();
           account.ADetails(sa);

            IAccount ca = new CurrentAccount();
            account.ADetails(ca);
           // ca.Details();
            Console.ReadLine();
        }
    }
}
