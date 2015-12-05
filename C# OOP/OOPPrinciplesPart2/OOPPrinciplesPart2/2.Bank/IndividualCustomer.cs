using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public  class IndividualCustomer:Customer
    {
        public decimal EGN { get; private set; }
        public string BornPlace { get; private set; }
        public IndividualCustomer(string name, decimal egn, string bornPlace)
            : base(name)
        {
            this.EGN = egn;
            this.BornPlace = bornPlace;
        }
        
    }
}
