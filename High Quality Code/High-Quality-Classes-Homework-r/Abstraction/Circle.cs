﻿namespace Abstraction
{
    using System;

    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Radius can not be less than 0");
            }
            else 
            {
                this.Radius = radius;
            }
        }

        public double Radius
        {
            get 
            { 
                return this.radius; 
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Radius can not be less than 0");
                }
                else 
                {
                    this.radius = value;
                }
            }         
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
