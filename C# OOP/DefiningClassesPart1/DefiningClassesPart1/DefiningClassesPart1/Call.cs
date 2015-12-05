using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    public class Call
    {
        //Fields
        private DateTime dateAndTime;
        private string dialedNumbers;
        private int duration;

        //Constructor
        public Call(DateTime dateAndTme, string dialedNumbers, int duration)
        {
            this.dateAndTime = dateAndTime;
            this.dialedNumbers = dialedNumbers;
            this.duration = duration;
        }
        
        //Properties
        public DateTime DateAndTime
        {
            get { return this.dateAndTime; }
            set { this.dateAndTime = value; }
        }
        public string DialedNumbers
        {
            get { return this.dialedNumbers; }
            set { this.dialedNumbers = value; }
        }
        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
    }
}