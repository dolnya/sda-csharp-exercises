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

        public LineSegment(MyPoint pointA, MyPoint pointB)
        {
            points.Add(pointA);
            points.Add(pointB); 
        }


        public LineSegment(int xA, int yA, int xB, int yB)
        {
            points.Add(new MyPoint(xA, yA));
            points.Add(new MyPoint(xB, yB));
        }
        public double Length()
        {
            return Math.Sqrt(Math.Pow(points[1].X - points[0].X, 2) + Math.Pow(points[1].Y - points[0].Y, 2));
        }
    }
}
