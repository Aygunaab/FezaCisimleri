using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FezaCisimleri
{
    class CylenderAndConeProperti:SpaceObjects
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        public double Slant_Height { get; set; }

        public override double Area()
        {
            throw new NotImplementedException();
        }

        public override double Volume()
        {
            throw new NotImplementedException();
        }
    }
}
