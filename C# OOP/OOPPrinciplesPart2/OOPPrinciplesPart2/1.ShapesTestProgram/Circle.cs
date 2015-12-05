using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ShapesTestProgram
{
    public class Circle:Shape
    {
        public Circle(double radius):base(radius)
        {
            
        }

        public override double CalculateSurface()
        {
            return Math.PI * this.Radius * this.Radius;
        }
    }
}
