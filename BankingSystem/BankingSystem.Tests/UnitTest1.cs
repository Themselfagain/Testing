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
        public void DepositShouldThrowMessage()
        {
            decimal deposit = -1;
            BankAccount bankAccount = new BankAccount(123);
            string exp = "Negative Amount";
            var act = Assert.Throws<InvalidOperationException>(
                () => bankAccount.Deposit(deposit));
            Assert.AreEqual(exp, act.Message);
        }
        [Test]
        public void DepositShouldIncreaseBalance()
        {
            BankAccount bankAccount = new BankAccount(123);
            decimal depositAmount = 100;
            bankAccount.Deposit(depositAmount);
            Assert.AreEqual(depositAmount, bankAccount.Balance);
        }
        [Test]
        public void AccountInicializeWithPositiveValues()
        {
            BankAccount bankAccount = new BankAccount(123, 2000m);
            Assert.AreEqual(2000m, bankAccount.Balance);


        }


    }
}