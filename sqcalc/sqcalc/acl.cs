﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqcalc
{
    abstract public class acl
    {
        public double x;
        public double y;

        public acl(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        abstract public double square();
    }
}
