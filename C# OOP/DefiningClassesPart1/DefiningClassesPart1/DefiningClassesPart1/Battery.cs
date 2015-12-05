using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    //Enumaration
     public enum BatteryTypes
        {
            LiIon, NiMH, NiCd 
        }

    public class Battery
    {
        //Fields
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        
        //Constructor - parameterless
        public Battery()
        { 

        }
        //Constructor with parameters
        public Battery(string model , int hoursIdle = 0, int hoursTalk = 0)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        //Properties
        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("This information is  not correct");
                }
                model = value;
            }
        }
        public int HoursIdle
        {
            get { return hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Not posible hours idle to be < 0");
                }
                hoursIdle = value;
            }
        }
        public int HoursTalk
        {
            get { return hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Not possible hours talk to be < 0");
                }
                hoursTalk = value;
            }
        }

       
    }
}

