using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNNums
{
    class SumNNums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double a = double.Parse(Console.ReadLine());
                sum += a;
            }
            Console.WriteLine(sum);
        }
    }
}
