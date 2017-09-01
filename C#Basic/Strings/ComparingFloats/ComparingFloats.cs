using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double a = Math.Round(double.Parse(Console.ReadLine()), 6);
            double b = Math.Round(double.Parse(Console.ReadLine()), 6);

            if (a == b)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
