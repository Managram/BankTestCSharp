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
            double expected = 0;

            account.Balance();


        }
    }
}
