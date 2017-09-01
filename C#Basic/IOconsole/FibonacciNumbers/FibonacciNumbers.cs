using System;
using System.Collections.Generic;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<long> numbers = new List<long>();
            for (int i = 0; i < n; i++)
            {
                numbers.Add(Fibonacci(i));
            }
            Console.WriteLine(string.Join(", ", numbers));

        }
        public static long Fibonacci(int n)
        {
            long a = 0;
            long b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
