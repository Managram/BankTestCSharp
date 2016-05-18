using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTechTest
{
    public class Account
    {
        public decimal balance;
        public const int default_balance = 0;

        public Account()
        {
            balance = default_balance;
        }

        public decimal Balance()
        {
            return balance;
        }

        public void Credit(decimal amount)
        {
            balance += amount;
        }

        public void Debit(decimal amount)
        {
            balance -= amount;
        }

    }
}
