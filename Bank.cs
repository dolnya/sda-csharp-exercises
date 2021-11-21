using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    internal class Bank

    {
        private List<Account> accounts = new List<Account>();

        public void AddAccount(Account account)
        {
            account.Add(account);
        }

        public decimal GetValue()
        {
            decimal total = 0;
            foreach (Account account in accounts)
            {

            }
        }


    }
}
