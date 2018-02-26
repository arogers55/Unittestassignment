using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class BankAccount
    {
        private int Balance { get; set; }

        public BankAccount()
        {
            BankAccount Acct = new BankAccount();
            Acct.Balance = 0;
        }

        public BankAccount(int startBal)
        {
            BankAccount Acct = new BankAccount();
            Acct.Balance = startBal;
        }

        public int GetBalance()
        {
            return Balance;
        }

        // Withdraws money from account.  
        // Return true if withdrawl successful, false if amt is negative or would overdraw account (do not perform transaction in those cases)
        public bool Withdraw(int amt)
        {
            BankAccount Acct = new BankAccount();
            if (Acct.Balance > amt)
            {
                Acct.Balance = Acct.Balance - amt;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Deposits amt into acocunt.  Returns true is operation successful, false otherwise.
        public bool Deposit(int amt)
        {
            BankAccount Acct = new BankAccount();
            if (amt > 0)
            {
                Acct.Balance = Acct.Balance + amt;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
