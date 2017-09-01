using System;

namespace HomeworkDefiningClassesPart2
{
    class Program
    {
        static void Main()
        {
            DateTime startdate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            DateTime after1000days = startdate.AddDays(999);
            Console.WriteLine(after1000days.ToString("dd-MM-yyyy"));
        }
    }
}
