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
            double a = 0, b = 0, s = 0;
            rect rt = new rect(a, b);
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            s = rt.square();
            Console.WriteLine(s);
        }
    }
}
