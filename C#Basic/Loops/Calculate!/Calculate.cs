using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_
{
    class Calculate
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double result = 0;
            for (int i = 0; i <= n; i++)
            {
                result += Factoriel(i) / Math.Pow(x, i);
            }
            Console.WriteLine("{0:f5}", result);
        }

        private static double Factoriel(double n)
        {
            double result = 1;
            for (double i = 2; i <= n; i++)
            {
                result *= i;

            }
            return result;
        }
    }
}
