using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                double a = double.Parse(input);
                if (a<0)
                {
                    Console.WriteLine("Invalid number");
                }
                else
                {
                    Console.WriteLine("{0:f3}", Math.Sqrt(a));
                }                
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            Console.WriteLine("Good bye");
        }
    }
}
