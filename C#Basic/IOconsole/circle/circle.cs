using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class circle
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double perimeter = Math.Round((Math.PI * (r + r)), 2);

            double area = Math.Round((Math.PI * r * r), 2);

            Console.Write("{0:f2}", perimeter);
            Console.Write(" ");
            Console.WriteLine("{0:f2}", area);

        }
    }
}
