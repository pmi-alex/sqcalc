using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqcalc
{
    class rect : acl
    {
        public double w { get; set; }
        public double h { get; set; }

        public rect(double x, double y, double h, double w) : base (x, y)
        {
            this.w = w;
            this.h = h;
        }

        public override double square()
        {
            return w * h;
        }
    }
}
