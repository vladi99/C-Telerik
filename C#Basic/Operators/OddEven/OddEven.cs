using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    class OddEven
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n%2==0)
            {
                Console.WriteLine("even " + n);
            }
            else
            {
                Console.WriteLine("odd " + n);
            }
        }
    }
}
