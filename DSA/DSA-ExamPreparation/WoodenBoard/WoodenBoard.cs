using System;
using System.Collections.Generic;

namespace WoodenBoard
{
    class WoodenBoard
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> charArr = new List<char>();
            int counter = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                charArr.Add(input[i]);
                if (isPolindrome(charArr))
                {
                    counter = charArr.Count;
                }
            }
            Console.WriteLine(input.Length - counter);
        }


        private static bool isPolindrome(List<char> arr)
        {
            int i, j;
            for (i = 0, j = arr.Count - 1; i < j; ++i, --j)
            {
                if (arr[i] != arr[j]) return false;
            }
            return true;
        }
    }
}
