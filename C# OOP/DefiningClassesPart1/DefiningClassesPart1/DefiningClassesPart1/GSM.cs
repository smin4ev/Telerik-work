using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    public class GSM
    {
        //Fields
        private string model;
        private string manifacturer;
        private int price;
        private string owner;
        
        //Static field for IPhone4S
        static private GSM iPhone4S;

        //Static field for CallHistory
        private List<Call> callHistory = new List<Call>();
        

        //Constructors
        public GSM(string model, string manifacturer)
        {
            this.model = model;
            this.manifacturer = manifacturer;
           
        }
        public GSM(string model, string manifacturer, int price, string owner)
        {
            this.Model = model;
            this.manifacturer = manifacturer;
            this.price = price;
            this.owner = owner;
                
        }

        //Property for IPhone4S
        public GSM IPhone4s
        {
            get { return iPhone4S; }
            set { iPhone4S = value; }   
        }
        //Property for Call History 
        public List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }
        //Properties
        public string Model
        {
            get { return this.model; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect information");
                }
                model = value;
            }
        }
        public string Manifacturer
        {
            get { return this.manifacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect information");
                }
                manifacturer = value;
            }
        }
        public int Price
        {
            get { return this.price; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price can not be < 0");
                }
                price = value;
            }
        }
        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect information");
                }
                owner = value;
            }
        }
        //Method for adding calls
        public void AddCalls(DateTime now, string number, int duration)
        {
            Call newCall = new Call(now, number, duration);
            this.callHistory.Add(newCall);
        }
        //Method for deleting calls
        public void DeleteCall(int indexOfCall)
        {
            this.callHistory.RemoveAt(indexOfCall);
        }
        //Method for clear the Call History
        public void ClearCallHistory()
        {
            this.callHistory.Clear();
            
        }
        //Method for calculating total price of calls in call history
        public double TotalPrice(double price)
        {
            double wholeSum = 0;
            double sum = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                sum = ((callHistory[i].Duration/60)+1) * price; //+1 because when start next minute even one second is count for a minute(from 0 to 59 second - 1 minute)
                wholeSum = wholeSum + sum;
                sum = 0;
            }
            return wholeSum;
        }
        

      
        //Override string
        public override string ToString()
        {

            return string.Format("This phone is {0}, manifacturer is{1}. Its prise is {2} and {3} buy it for his brother", this.model, this.manifacturer, this.price, this.owner);
        }

    }
}
