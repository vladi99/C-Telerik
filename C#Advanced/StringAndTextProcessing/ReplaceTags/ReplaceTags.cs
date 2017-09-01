using System;
using System.Text.RegularExpressions;

namespace ReplaceTags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string replaceTags = Regex.Replace(text, "(<a href=\")(.*?)(\">)(.*?)(</a>)", "[$4]($2)");
            Console.WriteLine(replaceTags);
        }
        
    }
}
