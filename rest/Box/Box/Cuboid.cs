using System;
using System.Collections.Generic;
using System.Text;

namespace Box
{
    class Cuboid
    {

        public double a;
        public double b;
        public double c;

        public Cuboid()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }
        public double GetSurface()
        {
            double tsa = 2 * (a*b + b*c + c*a);
            return tsa;
        }
        public double GetVolume()
        {
            double V = a * b * c;
            return V;
        }
    }
}
