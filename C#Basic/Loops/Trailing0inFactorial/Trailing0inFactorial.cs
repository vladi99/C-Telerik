using System;

namespace Trailing0inFactorial
{
    class Trailing0inFactorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 5; n/i >= 1; i *= 5)
            {
                counter += n / i;
            }
            Console.WriteLine(counter);
        }
    }
}
