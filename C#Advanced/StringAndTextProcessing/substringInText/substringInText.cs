using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substringInText
{
    class substringInText
    {
        static void Main(string[] args)
        {
            string substr = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();
            int count = 0;
            while (true)
            {
                int index = text.IndexOf(substr);
                if (index != -1)
                {
                    count++;
                    int start = index + substr.Length;
                    text = text.Substring(start, text.Length - start);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
