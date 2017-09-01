using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a >=1 && a<=3)
            {
                Console.WriteLine(a * 10);
            }
            else if (a >= 4 && a <= 6)
            {
                Console.WriteLine(a*100);
            }
            else if (a >= 7 && a <= 9)
            {
                Console.WriteLine(a*1000);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
