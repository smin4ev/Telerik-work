using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1.StructurePoint3D
{
    public static class PathStorage
    {
        public static string LoadFile(StreamReader load)
        {
            StringBuilder content = new StringBuilder();
            load = new StreamReader(@"..\..\PathLoad.txt");
            using (load)
            {
                    content.Append(load.ReadToEnd());   
            }
            return content.ToString();
        }


        public static void SaveFile(List<Point3D> points)
        {
            StreamWriter exitFile = new StreamWriter(@"..\..\PathSaves.txt");
            int count = 1;
            using (exitFile)
            {
                foreach (var point in points)
                {
                    Console.WriteLine("{0}. x={1}, y={2}, z={3}", count, point.X, point.Y, point.Z);
                        count++;
                }
            }

        }

    }
}
