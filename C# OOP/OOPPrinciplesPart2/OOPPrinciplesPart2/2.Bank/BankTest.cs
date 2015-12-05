using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    //A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
    //Customers could be individuals or companies.All accounts have customer, balance and interest rate (monthly based).
    //Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
    //All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated 
    //as follows: number_of_months * interest_rate.
    //Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
    //Deposit accounts have no interest if their balance is positive and less than 1000.
    //Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
    //Your task is to write a program to model the bank system by classes and interfaces. 
    //You should identify the classes, interfaces, base classes and abstract actions and 
    //implement the calculation of the interest functionality through overridden methods.


    class BankTest
    {
        static void Main(string[] args)
        {
            Customer[] groupOfCustomers = new Customer[]
            {
                new CompanyCustomer("CarsOOD", 123454321),
                new IndividualCustomer("Ivan Ivanov", 6709061316, "Sofia"),
                new IndividualCustomer("Georgi Petrov", 8211110812, "Varna"),
                new CompanyCustomer("PeshoOOD", 112123145)
            };

            Account[] groupOfAccount = new Account[]
            {
                new DepositAccount(groupOfCustomers[0], 12321, 4),
                new DepositAccount(groupOfCustomers[1], 32142343,5.5),
                new LoanAccount(groupOfCustomers[0], 1232, 3),
                new MortageAccount(groupOfCustomers[3], 555555,4),
                new MortageAccount(groupOfCustomers[2],123,3),
                new LoanAccount(groupOfCustomers[2],5512,7),
            };

            int counter = 1;
            foreach (var account in groupOfAccount)
            {
                Console.WriteLine("Acount number {0}:", counter );
                Console.WriteLine("Account interest is {0}",account.CalculateInterestAmount(10));
                Console.Write("deposit money:");
                account.DepositMoney(200);
                if (account is DepositAccount)
                {
                    Console.Write("withdrow money:");
                    account.WithdrowMoney(10);
                }
                counter++;
                Console.WriteLine();
                
            }
        }
    }
}
