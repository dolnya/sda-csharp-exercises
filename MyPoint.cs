using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    internal class MyPoint
    {

        public int X { get; private set;}
        public int Y { get; private set; }

        public MyPoint(int x , int y)
        {
            X = x;
            Y = y;
            
        }
    }
}
