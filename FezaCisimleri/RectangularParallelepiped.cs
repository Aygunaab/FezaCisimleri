using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FezaCisimleri
{
    class RectangularParallelepiped : SpaceObjects
    {
        public  double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public override double Area()
        {
            return 2 * ((a * b) + (b * c) + (a * c));
        }

        public override double Volume()
        {
            return a * b * c;
        }
    }
}
