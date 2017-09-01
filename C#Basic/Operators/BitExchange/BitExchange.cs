using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange
{
    class BitExchange
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int result = ExchangeBits(n, 3, 24);
            result = ExchangeBits(result, 4, 25);
            result = ExchangeBits(result, 5, 26);
            Console.WriteLine(result);
        }

        private static int ExchangeBits(int n, int p1, int p2 )
        {
            int bit1 = (n >> p1) & 1;
            int bit2 = (n >> p2) & 1;
            int x = (bit1 ^ bit2);
            x = (x << p1) | (x << p2);
            int result = n ^ x;
            
            return result;
        }
    }
}
