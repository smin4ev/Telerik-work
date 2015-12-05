using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Dimensions
{
    public class Size
    {
        private double width; 
        private double height;

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return width; }
            private set{width = value;}
        }
        public double Height
        {
            get { return height; }
            private set { height = value; }
        }

        public static Size GetRotatedSize(Size size, double angleOfRotateFigure)
        {
            

            double widthOfFigure = (Math.Abs(Math.Cos(angleOfRotateFigure)) * size.Width) +
            (Math.Abs(Math.Sin(angleOfRotateFigure)) * size.Height);

            double heightOfFigure = (Math.Abs(Math.Sin(angleOfRotateFigure)) * size.Width) +
            (Math.Abs(Math.Cos(angleOfRotateFigure)) * size.Height);

            Size figure = new Size(widthOfFigure, heightOfFigure);

            return figure;
        }


    }
}
