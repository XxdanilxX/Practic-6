using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_6
{
    internal class TCube:TSquare
    {
        public TCube() : base()
        {
        }

        public TCube(double side) : base(side)
        {
        }

        public TCube(TCube cube) : base(cube)
        {
        }

        public double Volume()
        {
            return Math.Pow(base.Area(), 1.5);
        }

        public new void Display()
        {
            Console.WriteLine($"Куб зі стороною {base.sideLength}");
        }
    }
}
