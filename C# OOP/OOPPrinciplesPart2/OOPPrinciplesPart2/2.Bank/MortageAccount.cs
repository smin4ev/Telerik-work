using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public class MortageAccount:Account
    {
        public MortageAccount(Customer someCustomer, double balance, double interestRate)
            : base(someCustomer, balance, interestRate)
        { 
        }

        public override void DepositMoney(double money)
        {
            this.Balance = this.Balance + money;
            Console.WriteLine(this.Balance);
        }

        public override double CalculateInterestAmount(int mounths)
        {
            if (mounths <= 12 && SomeCustomer is CompanyCustomer)
            { 
                return (mounths*InterestRate)/2;
            }
            else if (mounths <= 6 && SomeCustomer is IndividualCustomer)
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
