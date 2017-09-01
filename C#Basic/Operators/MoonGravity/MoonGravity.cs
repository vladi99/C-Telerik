using System;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double weightOnMoon = Math.Round((w * 0.17), 3);
            Console.WriteLine("{0:F3}", weightOnMoon);
        }
    }
}
