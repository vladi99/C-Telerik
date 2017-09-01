using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words
{
    class Words
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string text = Console.ReadLine();

            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string prefix = input.Substring(0, i + 1);
                string suffix = input.Substring(i + 1);

                int prefixCount = KMP(text, prefix);
                if (suffix.Length == 0)
                {
                    result += prefixCount;
                }
                else
                {
                    int suffixCount = KMP(text, suffix);
                    result += prefixCount * suffixCount;
                }

            }
            Console.WriteLine(result);
        }

        private static int KMP(string text, string pattern)
        {
            int counter = 0;
            var failLink = PreComputeKMP(pattern);

            int j = 0;
            for (int i = 0; i < text.Length; i++)
            {
                while (j >= 0 && pattern[j] != text[i])
                {
                    j = failLink[j];
                }

                ++j;
                if (j == pattern.Length)
                {
                    counter++;
                    j = failLink[j];
                }
            }
            return counter;
        }


        static int[] PreComputeKMP(string str)
        {
            var failLink = new int[str.Length + 1];
            failLink[0] = -1;
            failLink[1] = 0;
            for (int i = 1; i < str.Length; ++i)
            {
                int j = failLink[i];
                while (j >= 0 && str[i] != str[j])
                {
                    j = failLink[j];
                }

                failLink[i + 1] = j + 1;
            }

            return failLink;
        }
    }
}
