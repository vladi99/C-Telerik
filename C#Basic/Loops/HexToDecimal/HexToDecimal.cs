using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToDecimal
{
    class HexToDecimal
    {
        static void Main(string[] args)
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
            string hex = Console.ReadLine().ToLower();
            long dec = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                char valAt = hex[hex.Length - i - 1];
                dec +=  hexdecval[valAt] * (long)Math.Pow(16, i);
            }
            Console.WriteLine(dec);
        }
    }
}
