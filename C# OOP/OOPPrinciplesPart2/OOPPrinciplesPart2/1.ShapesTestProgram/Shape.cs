using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ShapesTestProgram
{
    public abstract class Shape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }
        public double Radius { get; private set; }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public Shape(double radius)
        {
            this.Radius = radius;
        }

        public abstract double CalculateSurface();
        
    }
}
