using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDigit
{
    class EnglishDigit
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string lastDigit = GetLastDigit(number);
            Console.WriteLine(lastDigit);
        }

        private static string GetLastDigit(string number)
        {
            char last = number[number.Length - 1];
            if (last == '1')
            {
                return "one";
            }
            else if (last == '2')
            {
                return "two";
            }
            else if (last == '3')
            {
                return "three";
            }
            else if (last == '4')
            {
                return "four";
            }
            else if (last == '5')
            {
                return "five";
            }
            else if (last == '6')
            {
                return "six";
            }
            else if (last == '7')
            {
                return "seven";
            }
            else if (last == '8')
            {
                return "eight";
            }
            else if (last == '9')
            {
                return "nine";
            }
            else
            {
                return "zero";
            }
        }
    }
}
