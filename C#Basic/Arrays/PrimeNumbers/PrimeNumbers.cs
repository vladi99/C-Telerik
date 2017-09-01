using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= 0; i--)
            {
                if (PrimeCheck(i))
                {
                    Console.WriteLine(i);
                    Environment.Exit(0);
                }
            }
        }

        private static bool PrimeCheck(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }

                }
                return true;
            }
        }
    }
}
