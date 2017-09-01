using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayCard
{
    class PlayCard
    {
        static void Main(string[] args)
        {
            string card = Console.ReadLine();
            if (card == "2" || card == "3" || card == "4" || card == "5" || card == "6" || card == "7" || card == "8" || card == "9" || card == "10" || card == "J" || card == "Q" || card == "K" || card == "A")
            {
                Console.WriteLine("yes " + card);
            }
            else
            {
                Console.WriteLine("no " + card);
            }
        }
    }
}
