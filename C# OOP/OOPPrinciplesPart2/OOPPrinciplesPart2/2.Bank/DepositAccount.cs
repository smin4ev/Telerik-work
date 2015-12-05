using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public class DepositAccount:Account, IDeposit
    {
        public DepositAccount(Customer someCustomer, double balance, double interestRate)
            : base(someCustomer, balance, interestRate)
        { 
        }

        public override void DepositMoney(double money)
        {
            this.Balance = this.Balance + money;
            Console.WriteLine(this.Balance);
        }

        public override void WithdrowMoney(double money)
        {
            if (this.Balance < money)
            {
                throw new ArgumentException("There is no enough money for drowing");
            }
            else
            {
                this.Balance = this.Balance - money;
            }
            Console.WriteLine(this.Balance);
        }

        public override double CalculateInterestAmount(int mounths)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            else 
            {
                return mounths * InterestRate;
            }
        }
    }
}
