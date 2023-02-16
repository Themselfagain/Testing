using NUnit.Framework;
using BankingSystem;
namespace BankingSystem.Tests
{
    public class Tests
    {
        [Test]
        public void DepositShouldIncreaseBalance()
        {
            BankAccount bankAccount = new BankAccount(123);
            decimal depositAmount = 100;
            bankAccount.Deposit(depositAmount);
            Assert.AreEqual(depositAmount, bankAccount.Balance);
        }
        public void AccountInicializeWithPositiveValues()
        {
            BankAccount bankAccount = new BankAccount(123, 2000m);
            Assert.AreEqual(2000m, bankAccount.Balance);
            
            
        }
        public void Test1()
        {
            Assert.Pass();
           

        }
    }
}