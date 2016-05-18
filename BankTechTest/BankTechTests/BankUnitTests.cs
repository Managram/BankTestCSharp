using BankTechTest;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTechTests
{
    [TestClass]
    public class BankUnitTests
    {
        [TestMethod]
        public void Balance()
        {
            Account account = new Account();
            decimal expected = 0;

            decimal actual = account.balance;

            Assert.AreEqual(expected, actual);


        }
    }
}
