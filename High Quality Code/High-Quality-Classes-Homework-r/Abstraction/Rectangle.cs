namespace Abstraction
{
    using System;

    public class Rectangle : Figure
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException("Width can not be less than 0!");
            }
            else
            {
                this.Width = width;
            }
            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException("Height can not be less than 0!");
            }
            else 
            {
                this.Height = height;
            }
        }
        
        public double Width
        {
            get 
            {
                return this.width; 
            }

            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width can not be less than 0!");
                }
                else 
                {
                    this.width = value;
                }
            }
        }

        public double Height
        {
            get 
            {
                return this.height;
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height can not be less than 0!");
                }
                else 
                {
                    this.height = value;
                }
            }
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * this.Width + 2 * this.Height;
            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface; 
        }
    }
}



