using BankTechTest;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTechTests
{
    [TestClass]
    public class BankUnitTests
    {
        [TestMethod]
        public void Account_initializesWithBalanceOfZero()
        {
            Account account = new Account();
            decimal expected = 0;

            decimal actual = account.Balance();

            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void Credit_AddsAmountToBalance()
        {
            Account account = new Account();
            decimal creditAmount = 10;
            decimal expected = 10;

            account.Credit(creditAmount);

            decimal actual = account.balance;

            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void Debit_RemovesAmountFromBalance()
        {
            Account account = new Account();
            decimal creditAmount = 10;
            decimal debitAmount = 5;
            decimal expected = 5;

            account.Credit(creditAmount);
            account.Debit(debitAmount);

            decimal actual = account.balance;

            Assert.AreEqual(expected, actual);
        }
    }
}
