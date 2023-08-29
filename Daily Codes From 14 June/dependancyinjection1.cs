using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class dependancyinjection1
    {
        public interface IAccount
        {
            void Details();
        }
        public class CurrentAccount : IAccount
        {
            public void Details()
            {
                Console.WriteLine("balance from current account");
            }
        }
        public class SavingAccount : IAccount
        {
            public void Details()
            {
                Console.WriteLine("balance from current account");
            }
        }
    }
}
