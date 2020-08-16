using System;

namespace ConsoleApp.Tests
{
    public class BankAccount
    {
        private double balance;

        public BankAccount(int v)
        {
            balance = v;
        }

        public BankAccount()
        {
            balance = 0;
        }

        public void deposit(int v)
        {
            balance += v;
        }

        public bool withdraw(int i)
        {
            // restrict withdrawal to amounts under 100000
            if (i < 100000)
            {
                balance -= i;
                if (balance < 0)
                {
                    balance -= 15;
                }
            return true;
            }
            return false;
        }

        public double getBalance()
        {
            return balance;
        }
    }
}