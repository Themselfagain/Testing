using NUnit.Framework;
using BankingSystem;
using System;

namespace BankingSystem.Tests
{
    public class Tests
    {
        [Test]
        public void ConstructorShouldWork()
        {
            int id = 123;
            BankAccount bankAccount = new BankAccount(id);
            Assert.AreEqual(id, bankAccount.Id);
        
        }
        [Test]
        [TestCase (-1,512)]
        [TestCase (-2,123)]
        public void DepositShouldThrow(decimal deposit, int id)
        {
            
            BankAccount bankAccount = new BankAccount(id);
            Assert.Throws<InvalidOperationException>(
                ()=>bankAccount.Deposit(deposit)) ;
        }
        [Test]
        public void BalanceShouldBeZero()
        {
            BankAccount bankAccount = new BankAccount(123);
            double balance = 0;
            Assert.AreEqual(balance, bankAccount.Balance);
        }
        [Test]
        public void BalanceShouldThrowMessage()
        {
            int id = 123;
            decimal amount = -100;
            string exp = "Balance must be positive or zero";
            var act = Assert.Throws<ArgumentException>(() => new BankAccount(id, amount));
            Assert.AreEqual(exp, act.Message);
        }
        [Test]
        public void BalanceShouldThrow()
        {
            int id = 123;
            decimal amount = -100;
            Assert.Throws<ArgumentException>(() => new BankAccount(id, amount));
        }
        [Test]
        public void DepositShouldThrowMessage()
        {
            decimal deposit = -1;
            BankAccount bankAccount = new BankAccount(123);
            string exp = "Negative Amount";
            var act = Assert.Throws<InvalidOperationException>(
                () => bankAccount.Deposit(deposit));
            Assert.AreEqual(exp, act.Message);
        }
        [TestCase(123,500)]
        [TestCase(123, 500.523)]
        [TestCase(123, 0)]

        public void ConstructorShouldSetBalanceAndId(int id, decimal amount)
        {
            BankAccount bankAccount = new BankAccount(id, amount);
            Assert.AreEqual(amount,bankAccount.Balance);
        }
        [Test]

        [TestCase(500)]
        [TestCase(1000)]
        
        public void BonusShouldIncreaseBalanceWhenLessThan1000(decimal amount)
        {
            BankAccount bankAccount = new BankAccount(123,amount);
            bankAccount.Bonus();
            Assert.AreEqual(amount, bankAccount.Balance);
        
        }
        [TestCase(1100)]
        [TestCase(2000)]

        public void BonusShouldIncreaseBalanceWhenBetweeen1000And2000(decimal amount)
        {
            BankAccount bankAccount = new BankAccount(123, amount);
            var exp = amount + 100;
            bankAccount.Bonus();
            Assert.AreEqual(exp, bankAccount.Balance);

        }


        [Test]
        public void DepositShouldIncreaseBalance()
        {
            int id = 123;
            decimal amount = 500;
            BankAccount bankAccount = new BankAccount(id,amount);
            decimal depositAmount = 100;
            bankAccount.Deposit(depositAmount);
            Assert.AreEqual(depositAmount+amount, bankAccount.Balance);
        }
        [Test]
        public void AccountInicializeWithPositiveValues()
        {
            BankAccount bankAccount = new BankAccount(123, 2000m);
            Assert.AreEqual(2000m, bankAccount.Balance);
        }


    }
}