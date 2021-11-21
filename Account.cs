using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    internal class Account 
    {
        public decimal Balance { get;private set; }

        public Account(decimal balance = 0M)
        {
            Balance = balance;
        }
        public void IncreaseBalance(decimal value)
        {
            Balance += value;
        }
        public virtual decimal GetValue()
        {
            return Balance;
        }

    }
}
