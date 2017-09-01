using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitSwap
{
    class BitSwap
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int startP = p;
            while (startP + k - 1 >= p)
            {
                n = ExchangeBits(n, p, q);               
                p++;
                q++;                
            }
            Console.WriteLine(n);

        }
        private static int ExchangeBits(int n, int p1, int p2)
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
