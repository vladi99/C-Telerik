using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDecimal
{
    class BinaryDecimal
    {
        static void Main()
        {
            string binary = Console.ReadLine();
            long dec = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - 1 - i] == '1')
                {
                    dec += (long)Math.Pow(2, i);
                }
            }
            Console.WriteLine(dec);
        }
    }
}
