using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankLib;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConstructorTest()
        {
            BankAccount Acct = new BankAccount();

            Assert.AreEqual(Acct.Balance, 0);
        }
    }
}
