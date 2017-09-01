using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHex
{
    class DecimalToHex
    {
        static void Main(string[] args)
        {
            long dec = long.Parse(Console.ReadLine());
            string hex = null;
            string remainderStr = null;
            long remainder = 0;

            while (dec > 0)
            {
                remainder = dec % 16;
                dec /= 16;
                if (remainder < 10)
                {
                    remainderStr = remainder.ToString();
                }
                else if (remainder == 10)
                {
                    remainderStr = "A";

                }
                else if (remainder == 11)
                {
                    remainderStr = "B";
                }
                else if (remainder == 12)
                {
                    remainderStr = "C";
                }
                else if (remainder == 13)
                {
                    remainderStr = "D";
                }
                else if (remainder == 14)
                {
                    remainderStr = "E";
                }
                else if (remainder == 15)
                {
                    remainderStr = "F";
                }
                hex = remainderStr + hex;
            }
            Console.WriteLine(hex);
        }
    }
}
