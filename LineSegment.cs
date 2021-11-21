using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace sda_csharp_exercises
{
    internal class LineSegment
    {
        private List<MyPoint> points = new List<MyPoint>();
        private List<MyPoint3D> points3D = new List<MyPoint3D>();
        public LineSegment(MyPoint3D pointA, MyPoint3D pointB)
        {
            points3D.Add(pointA);
            points3D.Add(pointB); 
        }
        public double Length()
        {
            return Math.Sqrt(Math.Pow(points3D[1].X - points3D[0].X, 2) + Math.Pow(points3D[1].Y - points3D[0].Y, 2) );
        }


        public double Length3D()
        {
            return Math.Sqrt(Math.Pow(points3D[1].X - points3D[0].X, 2) + Math.Pow(points3D[1].Y - points3D[0].Y, 2) + Math.Pow(points3D[1].Z - points3D[0].Z, 2));
        }
        public LineSegment(int xA, int yA, int xB, int yB, int zA, int zB)
        {
            points3D.Add(new MyPoint3D(xA, yA,zA));
            points3D.Add(new MyPoint3D(xB, yB,zB));
        }
    }
}
