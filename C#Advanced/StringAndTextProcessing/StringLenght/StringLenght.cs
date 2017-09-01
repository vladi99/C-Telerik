using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLenght
{
    class StringLenght
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = input;
            for (int i = input.Length + 1; i <= 20; i++)
            {
                output += "*";
            }
            Console.WriteLine(output);
        }
    }
}
