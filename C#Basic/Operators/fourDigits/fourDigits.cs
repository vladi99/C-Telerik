using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourDigits
{
    class fourDigits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = (n / 1000) % 10;
            int b = (n / 100) % 10;
            int c = (n / 10) % 10;
            int d = n % 10;
            int sum = a + b + c + d;
            string reversed = d + "" + c + "" + b + "" + a + "";
            string lastDigitFirst = d + "" + a + "" + b + "" + c + "";
            string secondAndThird = a + "" + c + "" + b + "" + d + "";
            Console.WriteLine(sum);
            Console.WriteLine(reversed);
            Console.WriteLine(lastDigitFirst);
            Console.WriteLine(secondAndThird);
        }
    }
}
