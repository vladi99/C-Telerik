using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string reversed = GetReversedNumber(number);
            Console.WriteLine(reversed);
        }

        private static string GetReversedNumber(string number)
        {
            string reversed = null;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversed += number[i];
            }
            return reversed;
        }
    }
}
