using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqcalc
{
    class Program
    {
        static void Main(string[] args)
        {
            acl sq = new acl();
            double a = 0, b = 0;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            sq.square(a, b);
        }
    }
}
