using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coordinates1 = Console.ReadLine().Split();
            string[] coordinates2 = Console.ReadLine().Split();
            string[] coordinates3 = Console.ReadLine().Split();

            Point point1 = new Point(int.Parse(coordinates1[0]), int.Parse(coordinates1[1]));
            Point point2 = new Point(int.Parse(coordinates2[0]), int.Parse(coordinates2[1]));
            Point point3 = new Point(int.Parse(coordinates3[0]), int.Parse(coordinates3[1]));

            double mr = (point2.Y - point1.Y) / (point2.X - point1.X);
            double mt = (point3.Y - point2.Y) / (point3.X - point2.X);

            double x = (mr * mt * (point3.Y - point1.Y) + mr * (point2.X + point3.X) - mt * (point1.X + point2.X)) / (2 * (mr - mt));
            double y = (-1 / mr) * (x - ((point1.X + point2.X) / 2)) + ((point1.Y + point2.Y) / 2);
            Console.WriteLine("{0:F4} {1:F4}", x, y);
        }
    }

    class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
