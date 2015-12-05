using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public abstract class Account
    {
        public Customer SomeCustomer { get; private set; }
        public double Balance { get; set; }
        public double InterestRate { get; private set; }

        public Account(Customer someCustomer, double balance, double interestRate)
        {
            this.SomeCustomer = someCustomer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public virtual void DepositMoney(double money)
        {
            
        }
        public virtual void WithdrowMoney(double money)
        {
            
        }

        public abstract double CalculateInterestAmount(int mounths);
    }
}
