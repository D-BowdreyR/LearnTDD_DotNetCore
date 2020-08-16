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
        public void Test1()
        {
            BankAccount acc = new BankAccount();
            acc.deposit(50);
            Assert.AreEqual(acc.balance, 50);
        }
    }
}