using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    public class Display
    {
        //Fields
        private int size;
        private int numberOfColours;

        //Constructor - parameterless
        public Display()
        { 
        }

        //Constructor with parameters
        public Display(int size, int numberOfColours)
        {
            this.size = size;
            this.numberOfColours = numberOfColours;
        }

        //Property
        public int Size
        {
            get { return size; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Size must be > 0");
                }
                size = value;
            }
        }
        public int NumberOfColours
        {
            get { return numberOfColours; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of colours must be > 0");

                }
                numberOfColours = value;
            }
        }

    }
}
