﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class dependancyinjection1
    {
        //cnotructor injections
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
        class Account
        {
            private IAccount account;
            public Account(IAccount account)
            {
                this.account = account;
            }
            public void printDetails()
            {
                account.Details();
            }
        }
        public static void Main(string[] args)
        {
            IAccount sa = new SavingAccount();
            Account account = new Account(sa);
            sa.Details();


            IAccount ca = new CurrentAccount();
            Account account1 = new Account(ca);
            ca.Details();

            Console.ReadLine();

        }
    }
}
