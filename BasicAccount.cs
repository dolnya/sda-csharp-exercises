using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    internal class BasicAccount
    {
        public decimal Balance { get; private set; }
        public decimal Intrest { get; private set; }

        public BasicAccount(decimal balance = 0M)
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
