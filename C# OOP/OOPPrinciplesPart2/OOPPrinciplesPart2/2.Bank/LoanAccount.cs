using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public class LoanAccount:Account
    {
        public LoanAccount(Customer someCustomer, double balance, double interestRate)
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
            if (mounths <= 3 && SomeCustomer is IndividualCustomer)
            {
                return 0;
            }
            else if (mounths <= 2 && SomeCustomer is CompanyCustomer)
            {
                return 0;
            }
            else
            {
                return mounths * this.InterestRate;
            }
        }
    }
}
