using System;
using System.Collections.Generic;
using System.Numerics;

namespace ColourBalls
{
    class ColourBalls
    {
        static void Main(string[] args)
        {
            var factorials = new BigInteger[31];
            factorials[0] = 1;
            for (int i = 1; i < factorials.Length; i++)
            {
                factorials[i] = factorials[i - 1] * i;
            }
            string input = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (dict.ContainsKey(input[i]))
                {
                    dict[input[i]]++;
                }
                else
                {
                    dict[input[i]] = 1;
                }
            }

            BigInteger result = factorials[input.Length];
            foreach (var value in dict.Values)
            {
                result /= factorials[value];
            }
            Console.WriteLine(result);
        }
    }
}
