using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBit
{
    class NBit
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int indexOfBit = 3;
            int bit = (num & (1 << indexOfBit)) >> indexOfBit;
            Console.WriteLine(bit);
        }

    }
}
