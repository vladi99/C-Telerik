using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lastDigit = (n / 100) % 10; // take third digit from right to left
            if (lastDigit == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false " + lastDigit);
            }
        }
    }
}
