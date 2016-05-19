using BankTechTest;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTechTests
{
    [TestClass]
    public class BankUnitTests
    {
        [TestMethod]
        public void Account_initializesWith_BalanceOfZero()
        {
            Account account = new Account();
            decimal expected = 0;

            decimal actual = account.Balance();

            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void Account_initializesWith_BlankTransactionHistory()
        {
            Account account = new Account();
            string expected = "date || credit || debit || balance \n";

            string actual = account.History();

            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void Credit_AddsAmount_ToBalance()
        {
            Account account = new Account();
            decimal creditAmount = 10;
            decimal expected = 10;

            account.Credit(creditAmount);

            decimal actual = account.Balance();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Credit_RecordsTransaction_InHistory()
        {
            Account account = new Account();
            string date = DateTime.Now.ToString("dd/MM/yy");
            decimal creditAmount = 10;
            string expected = "date || credit || debit || balance \n" + date + " || 10 || || 10 \n";

            account.Credit(creditAmount);

            string actual = account.History();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Debit_RemovesAmount_FromBalance()
        {
            Account account = new Account();
            decimal creditAmount = 10;
            decimal debitAmount = 5;
            decimal expected = 5;

            account.Credit(creditAmount);
            account.Debit(debitAmount);

            decimal actual = account.Balance();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Debit_RecordsTransaction_InHistory()
        {
            Account account = new Account();
            string date = DateTime.Now.ToString("dd/MM/yy");
            decimal creditAmount = 10;
            decimal debitAmount = 5;
            string expected = "date || credit || debit || balance \n" + date + " || 10 || || 10 \n" + date + " || || 5 || 5 \n";

            account.Credit(creditAmount);
            account.Debit(debitAmount);

            string actual = account.History();
            Assert.AreEqual(expected, actual);
        }
    }
}
