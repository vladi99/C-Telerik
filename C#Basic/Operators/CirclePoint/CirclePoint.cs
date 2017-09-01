using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePoint
{
    class CirclePoint
    {
        static void Main(string[] args)
        {
            double x = Math.Abs(double.Parse(Console.ReadLine()));
            double y = Math.Abs(double.Parse(Console.ReadLine()));
            double distance = Math.Round((Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))), 2);
            if (distance<=2)
            {
                Console.Write("yes ");                
            }
            else
            {
                Console.Write("no ");
            }
            Console.WriteLine("{0:f2}", distance);
        }
    }
}
