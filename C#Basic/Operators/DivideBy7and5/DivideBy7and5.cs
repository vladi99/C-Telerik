using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy7and5
{
    class DivideBy7and5
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n%5 == 0 && n%7==0)
            {
                Console.WriteLine("true " + n);
            }
            else
            {
                Console.WriteLine("false " + n);
            }
        }
    }
}
