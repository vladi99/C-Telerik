using System;
using System.Globalization;
using System.Threading;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string str = Console.ReadLine();
                        
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write("\\u{0:X4}", (int)str[i]);
            }
            Console.WriteLine();
        }
    }
}
