using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDeck
{
    class PrintDeck
    {
        static void Main(string[] args)
        {
            int n = 0;
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "J":
                    n = 11;
                    break;
                case "Q":
                    n = 12;
                    break;
                case "K":
                    n = 13;
                    break;
                case "A":
                    n = 14;
                    break;
                default:
                    n = int.Parse(sign);
                    break;
            }

            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine(cards[i] + " of spades, " + cards[i] + " of clubs, " + cards[i] + " of hearts, "+ cards[i] + " of diamonds");
            }


        }
    }
}
