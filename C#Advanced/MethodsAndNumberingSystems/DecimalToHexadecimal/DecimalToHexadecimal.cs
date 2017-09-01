using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            long dec = HexToDecimal(hex);
            PrintBinary(dec);
        }

        private static void PrintBinary(long number)
        {
            string binary = null;
            while (number > 0)
            {
                if (number % 2 == 0)
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

        static private long HexToDecimal(string hex)
        {
            Dictionary<char, int> hexdecval = new Dictionary<char, int>{
                {'0', 0},
                {'1', 1},
                {'2', 2},
                {'3', 3},
                {'4', 4},
                {'5', 5},
                {'6', 6},
                {'7', 7},
                {'8', 8},
                {'9', 9},
                {'a', 10},
                {'b', 11},
                {'c', 12},
                {'d', 13},
                {'e', 14},
                {'f', 15},
            };
            long dec = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                char valAt = hex[hex.Length - i - 1];
                dec += hexdecval[valAt] * (long)Math.Pow(16, i);
            }
            return dec;
        }
    }
}
