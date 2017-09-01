using System;

namespace Rectangle
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double area = h * w;
            double P = 2 * (h + w);
            Console.Write("{0:f2}", area);
            Console.Write(" ");
            Console.Write("{0:f2}", P);
            Console.WriteLine();
        }
    }
}
