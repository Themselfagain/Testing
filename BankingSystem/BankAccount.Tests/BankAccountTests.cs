using NUnit.Framework;
using BankAccount;
using BankingSystem;
namespace BankAccount.Tests
{
    [TestFixture]
    public class BankAccountTests
    {

        [Test]
        
        public void DepositShouldIncreaseBalance()
        {
            {
                BankAccount bankAccount = new BankAccount(123);
                decimal depositAmount = 100;

                bankAccount.Deposit(depositAmount);

                Assert.AreEqual(depositAmount, bankAccount.Balance);
            }
        }
        [SetUp]
        public void Setup()
        {
        }
        public void Test1()
        {
            Assert.Pass();
        }
    }
}