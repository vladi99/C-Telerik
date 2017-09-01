using System;
namespace random
{
    class random
    {
        static void Main(string[] args)
        {
            Random randomNumbers = new Random();
            while (true)
            {
                string key = Console.ReadKey().Key.ToString();
                Console.WriteLine(randomNumbers.Next(1, 49));
                if (key == "Enter")
                {
                    continue;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
