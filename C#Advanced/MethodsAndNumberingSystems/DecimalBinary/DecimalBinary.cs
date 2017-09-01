using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalBinary
{
    class DecimalBinary
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string binary = null;
            while (number > 0)
            {
                if (number%2 == 0)
                {
                    binary += "0";
                }
                else
                {
                    binary += "1";
                }
                number /= 2;
            }
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                Console.Write(binary[i]);
            }
            Console.WriteLine();
        }
    }
}
