using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBit
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            uint position = uint.Parse(Console.ReadLine());
            uint v = uint.Parse(Console.ReadLine());
            ulong result = 0;
            if (v == 1)
            {
                ulong mask = (ulong)1 << (int)position;
                result = mask | number;               
            }
            else
            {
                ulong mask = ~((ulong)1 << (int)position);
                result = mask & number;
            }
            Console.WriteLine(result);
        }
    }
}
