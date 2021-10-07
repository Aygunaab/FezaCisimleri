using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FezaCisimleri
{
    class Cylinder :CylenderAndConeProperti
    {
       
        public override double Area()
        {
            double Areaot = 3.14 * Radius * Radius;
            return 2 * Areaot + 2 * 3.14 * Radius * Slant_Height;
        }

        public override double Volume()
        {
            return 3.14 * Radius * Radius * Slant_Height;
        }
    }
}
