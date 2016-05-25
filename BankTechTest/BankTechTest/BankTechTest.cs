using System;
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
        private const string history_header = "date || credit || debit || balance \n";
        private string date;
        DateTime dateAndTime = DateTime.Now;
        private readonly ITransaction _transaction;

        public Account(ITransaction transaction)
        {
            balance = default_balance;
            history = history_header;
            _transaction = transaction;
        }

        private string returnDate()
        {
            return date = dateAndTime.ToString("dd/MM/yy");
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
            history += new Transaction(amount, 0, balance);
        }

        public void Debit(decimal amount)
        {
            balance -= amount;
            history += new Transaction(0, amount, balance);
        }
    }

    public interface ITransaction
    {
    }

    public class Transaction
    {
        private string date;
        private string dateToday;
        DateTime dateAndTime = DateTime.Now;
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal Balance { get; set; }

        private string returnDate()
        {
            return date = dateAndTime.ToString("dd/MM/yy");
        }

        public Transaction(decimal debit_amount, decimal credit_amount, decimal balance)
        {
            dateToday = returnDate();
            Credit = credit_amount;
            Debit = debit_amount;
            Balance = balance;
        }
    }

}
