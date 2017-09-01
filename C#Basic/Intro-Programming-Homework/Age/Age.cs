using System;

namespace Age
{
    class Age
    {
        static void Main(string[] args)
        {
            DateTime BirthDay = DateTime.Parse(Console.ReadLine());
            int age = (int)((DateTime.Now.AddMonths(-7) - BirthDay).TotalDays / 365.242199);
            Console.WriteLine(age);
            Console.WriteLine(age + 10);

        }
    }
}
