using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLib
{
    public class BankAccount
    {

        public int Balance { get; set;}


        public BankAccount()
        {
            Balance = 0;
        }

        public BankAccount(int startBal)
        {
            Balance = startBal;
        }

        public int GetBalance()
        {
            return Balance;
        }

        // Withdraws money from account.  
        // Return true if withdrawl successful, false if amt is negative or would overdraw account (do not perform transaction in those cases)
        public bool Withdraw(int amt)
        {

            if (Balance > amt)
            {
                Balance = Balance - amt;
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
            if (amt > 0)
            {
                Balance = Balance + amt;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
