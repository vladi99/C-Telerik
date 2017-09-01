using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCirlcleRectangle
{
    class PointCirlcleRectangle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distance = (Math.Sqrt(Math.Pow(x-1, 2) + Math.Pow(y-1, 2)));
            if (distance <= 1.5)
            {
                Console.Write("inside circle ");
            }
            else
            {
                Console.Write("outside circle ");
            }

            if ((x >= -1 && x <= 5) && (y <= 1 && y >= -1))
            {
                Console.Write("inside rectangle");
            }
            else
            {
                Console.Write("outside rectangle");
            }
            Console.WriteLine();
        }
    }
}
