using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            string hexA = a.ToString("X");
            string binary = Convert.ToString(a, 2);
            string b2 = b.ToString("0.00");
            string c3 = c.ToString("0.000");
            Console.Write(hexA.PadRight(10));
            Console.Write("|");
            Console.Write(binary.PadLeft(10, '0'));
            Console.Write("|");
            Console.Write(b2.PadLeft(10));
            Console.Write("|");
            Console.WriteLine(c3.PadRight(10));

        }
    }
}
