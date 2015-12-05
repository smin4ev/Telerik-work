using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StructurePoint3D
{
    public struct Point3D
    {
        private int x;
        private int y;
        private int z;
        
        //task 2
        public static readonly Point3D startPoint = new Point3D(0, 0, 0); 
        //end

        public Point3D(int X, int Y, int Z):this()
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }
        public int X
        {
            get { return this.x;}
            set { this.x = value; }
        }
        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        } 
        public int Z
        {
            get { return this.z; }
            set { this.y = value; }
        }


        //task 2
        public  Point3D StartPoint
        {
            get { return this.StartPoint; }
        }
        //end


        public override string ToString()
        {
            return string.Format("Point x = {0}, point y={1}, point z = {2}", this.x, this.y, this.z);
        }
    }
    

}
