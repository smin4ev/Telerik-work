using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StructurePoint3D
{
    public class Path
    {
       public readonly ICollection <Point3D> AllPoints = new List<Point3D>();
       public void AddPoint(Point3D point)
       {
           AllPoints.Add(point);
       }
    }
}
