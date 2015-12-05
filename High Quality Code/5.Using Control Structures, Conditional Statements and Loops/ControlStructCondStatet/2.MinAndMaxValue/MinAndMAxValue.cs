using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MinAndMaxValue
{
    class MinAndMAxValue
    {
        public static void Main(string[] args)
        {
            int MIN_X = 0;
            int MAX_X = 100;
            int MIN_Y = 20;
            int MAX_Y = 200;

            int x = 15;
            int y = 40;

            bool shouldVisitCell = true;

            bool xCoordinateInRange = (MIN_X < x) && (x < MAX_X);
            bool yCoordinateInRange = (MIN_Y < y) && (y < MAX_Y);

            if (xCoordinateInRange && yCoordinateInRange && shouldVisitCell)
            {
                VisitCell();
            }

        }
        public static void VisitCell()
        {
            Console.WriteLine("Cell is visited");
        }
    }
}
