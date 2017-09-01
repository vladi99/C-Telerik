using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort3Nums
{
    class Sort3Nums
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a>b)
            {
                if (a>c)
                {
                    if (b>=c)
                    {
                        Console.WriteLine("{0} {1} {2}", a, b, c);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", a, c, b);
                    }
                
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
            }
            else if (a==b)
            {
                if (c>a)
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
            }
            else
            {
                if (b>c)
                {
                    if (a >= c)
                    {
                        Console.WriteLine("{0} {1} {2}", b, a, c);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", b, c, a);
                    }
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
            }
        }
    }
}
