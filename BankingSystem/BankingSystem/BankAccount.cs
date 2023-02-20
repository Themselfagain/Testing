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
        public void Credit(decimal cash)
        {
            if (cash <= 0)
            {
                throw new ArgumentException("The amount must be positive!");
            }
            this.Balance += cash;
        }
        public void Increase(double percent)
        {
            if (percent <= 0)
            {
                throw new ArgumentException("The percent must be positive!");
            }
            else
            {
                this.Balance = Balance + Balance * (decimal)percent;
            }
        }
        public void Bonus()
        {
            if (this.Balance > 1000&&this.Balance<2000)
            {
                this.Balance += 100;
            }
            else if (this.Balance >= 2000&&this.Balance<=3000)
            {
                this.Balance += 200;
            }
            else if(this.Balance>3000)
            {
                this.Balance += 300;
            }
        }
    }
}