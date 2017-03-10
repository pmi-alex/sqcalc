using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqcalc
{
    class rect : acl
    {
        public rect(double x, double y) : base (x, y)
        {
            this.x = x;
            this.x = y;
        }

        public override double square()
        {
            return x * y;
        }
    }
}
