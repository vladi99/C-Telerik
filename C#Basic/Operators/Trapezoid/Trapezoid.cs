using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double trapezoidArea = Math.Round(((a + b) / 2 * h), 7);
            Console.WriteLine("{0:f7}", trapezoidArea);
        }
    }
}
