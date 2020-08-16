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
            // Arrange
            BankAccount acc = new BankAccount();
            // Act
            acc.deposit(50);
            // Assert
            Assert.AreEqual(50, acc.getBalance());
        }

        [Test]
        public void Testwithdraw()
        {
            // Arrange
            BankAccount acc = new BankAccount(75);
            // Act
            acc.withdraw(50);
            // Assert
            Assert.AreEqual(25, acc.getBalance());
        }

        [Test]
        public void withdraw_BalanceBecomesNegative_ExpectBalanceToBeReducedByPenalty()
        {
            // Arrange
            BankAccount acc = new BankAccount(30);
            // Act
            acc.withdraw(40);
            // Assert
            var expected_balance_after_penalty = (30 - 40)-15;
            Assert.AreEqual(expected_balance_after_penalty, acc.getBalance());
        }

        //requirement to reject withdrawals of 100000 or greater
        [Test]
        public void withdraw_OverPermittedAmount_ExpectBalanceToRemainUnchanged()
        {
            // Arrange
            BankAccount acc = new BankAccount(100);

            // Act
            // Assert
            Assert.False(acc.withdraw(100000));
            Assert.AreEqual(100,acc.getBalance());

            Assert.True(acc.withdraw(1));
            Assert.AreEqual(99,acc.getBalance());
        }
    }
}