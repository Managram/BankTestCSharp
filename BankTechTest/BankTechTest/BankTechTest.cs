﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTechTest
{
    public class Account
    {
        private decimal balance;
        private string history;
        private const int default_balance = 0;
        private const string history_header = "date || credit || debit || balance";
        DateTime dateAndTime = DateTime.Now;
        private string date = dateAndTime.ToString("dd/MM/yyyy"));

        public Account()
        {
            balance = default_balance;
            history = history_header;
        }

        public string History()
        {
            return history;
        }

        public decimal Balance()
        {
            return balance;
        }

        public void Credit(decimal amount)
        {
            balance += amount;
            history += "" + date + "||" + amount + "|| ||" + balance + "\n"; ;
        }

        public void Debit(decimal amount)
        {
            balance -= amount;
        }

    }
}
