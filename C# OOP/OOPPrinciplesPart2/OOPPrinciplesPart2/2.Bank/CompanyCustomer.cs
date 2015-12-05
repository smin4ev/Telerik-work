using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public class CompanyCustomer:Customer
    {
        public double Bulstat{get; private set;}
        public CompanyCustomer(string name, double bulstat)
            : base(name)
        {
            this.Bulstat = bulstat;
        }
    }
}
