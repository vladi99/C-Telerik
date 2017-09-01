using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOfThree
{
    class BiggestOfThree
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double biggest = Math.Max(a, (Math.Max(b, c)));
            Console.WriteLine(biggest);
        }
    }
}
