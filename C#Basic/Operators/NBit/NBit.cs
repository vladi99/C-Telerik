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
            long num = long.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            long bit = (num >> position) & 1;
            Console.WriteLine(bit);
        }

    }
}
