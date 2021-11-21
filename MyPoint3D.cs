using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    internal class MyPoint3D : MyPoint
    {
       public int Z { get; private set; }
        public MyPoint3D(int x, int y, int z) : base (x, y)
        {
            Z = z;
        }
    }
}
