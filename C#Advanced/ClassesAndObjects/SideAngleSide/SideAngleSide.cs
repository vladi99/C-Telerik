using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideAngleSide
{
    class SideAngleSide
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());
            double angleInRadians = ConvertToRadians(angle);    
            double area = (a * b * Math.Sin(angleInRadians)) / 2;
            Console.WriteLine("{0:f2}", area);

        }
        public static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }
    }
}
