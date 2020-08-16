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

        public void withdraw(int i)
        {
            balance -= i;
            if (balance < 0)
            {
                balance -= 15;
            }
        }

        public double getBalance()
        {
            return balance;
        }
    }
}