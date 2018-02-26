using System;
using Xunit;
using PointLib;
using BankLib;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        BankAccount Acct = new BankAccount();
        Point p = new Point();

        [Fact]
        public void ConstructorTest()
        {
           
            Assert.Equal(Acct.Balance, 0);
        }

        [Fact]
        public void ConstructorTest2()
        {
            BankAccount Acct2 = new BankAccount(100);
            Point p = new Point();

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

        // Point Tests

        [Fact]
        public void PointConstructorTest()
        {
            Assert.Equal(p.getX(), 0);
            Assert.Equal(p.getY(), 0);
        }

        [Fact]
        public void PointConstructorTest2()
        {
            Point p2 = new Point(2, 5);
            Assert.Equal(p2.getX(), 2);
            Assert.Equal(p2.getY(), 5);
        }

        [Fact]
        public void StretchTest()
        {
            Point p2 = new Point(2, 5);
            p2.Stretch(4);

            Assert.Equal(p2.getX(), 8);
            Assert.Equal(p2.getY(), 20);
        }
    }
}
