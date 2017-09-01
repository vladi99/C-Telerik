using System;

namespace BiggestOf5
{
    class BiggestOf5
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double biggest = Math.Max(a, (Math.Max(b, Math.Max(c, Math.Max(d, e)))));
            Console.WriteLine(biggest);
        }
    }
}
