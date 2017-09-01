using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int dec = int.Parse(Console.ReadLine());
            string binary = null;
            int remainder = 0;
            while (dec > 0)
            {
                remainder = dec % 2;
                dec /= 2;
                binary = remainder.ToString() + binary;
            }
            Console.WriteLine(binary);
        }
    }
}
