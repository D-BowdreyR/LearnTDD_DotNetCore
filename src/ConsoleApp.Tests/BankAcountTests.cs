using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class BankAccountTests
    {
        // [SetUp]
        // public void Setup()
        // {
        // }

        [Test]
        public void Testdeposit()
        {
            BankAccount acc = new BankAccount();
            acc.deposit(50);
            Assert.AreEqual(50, acc.getBalance());
        }

        [Test]
        public void Testwithdraw()
        {
            BankAccount acc = new BankAccount(75);
            acc.withdraw(50);
            Assert.AreEqual(25, acc.getBalance());
        }

        [Test]
        public void withdraw_BalanceBecomesNegative_ExpectBalanceToBeReducedByPenalty()
        {
            BankAccount acc = new BankAccount(30);
            acc.withdraw(40);
            var expected_balance_after_penalty = (30 - 40)-15;
            Assert.AreEqual(expected_balance_after_penalty, acc.getBalance());
        }
    }
}