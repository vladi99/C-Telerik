using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());
            decimal sum = a + b + c;
            Console.WriteLine(sum);
        }
    }
}
