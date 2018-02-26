using System;
using Xunit;
using BankLib;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        BankAccount Acct = new BankAccount();

        [Fact]
        public void ConstructorTest()
        {
           
            Assert.Equal(Acct.Balance, 0);
        }

        [Fact]
        public void ConstructorTest2()
        {
            BankAccount Acct2 = new BankAccount(100);

            Assert.Equal(Acct2.Balance, 100);
        }

        [Fact]
        public void WithdrawTest()
        {
            BankAccount Acct2 = new BankAccount(100);
            Acct2.Withdraw(50);

            Assert.Equal(Acct2.Balance, 50);
        }

        [Fact]
        public void WithdrawExceptionTest()
        {
            BankAccount Acct2 = new BankAccount(25);
            Assert.False(Acct2.Withdraw(50));
        }

        [Fact]
        public void DepositTest()
        {
            BankAccount Acct2 = new BankAccount(100);
            Acct2.Deposit(50);

            Assert.Equal(Acct2.Balance, 150);
        }

        [Fact]
        public void DepositExceptionTest()
        {
            BankAccount Acct2 = new BankAccount(100);
            Assert.False(Acct2.Deposit(-50));
        }
    }
}
