using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(int id, decimal balance = 0)
        {
            this.Id = id;
            this.Balance = balance;
        }
        public int Id { get; set; }
        public decimal Balance
        {
            get { return balance; }
            set
            {
                this.balance = value; if (balance<0)
                {
                    throw new ArgumentException("Balance must be positive or zero");
                }
            } }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException("Negative Amount");
            }
            this.Balance += amount;
        }
    }
}