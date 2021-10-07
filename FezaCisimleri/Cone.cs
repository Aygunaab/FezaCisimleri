using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FezaCisimleri
{
    class Cone: CylenderAndConeProperti
    {
       

        public override double Area()
        {
            return 3.14 * Radius * (Radius + Slant_Height);
        }

        public override double Volume()
        {
            double AreaOt = 3.14 * Radius * Radius;
            return AreaOt * Height / 3;
        }
    }
}
