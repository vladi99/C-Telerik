using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(year, 01, 01);
            var lastdate = new DateTime(year, 12, 31);
            var daysInCurrentYear = lastdate - date;
            if (daysInCurrentYear.Days == 364)
            {
                Console.WriteLine("Common");
            }
            else
            {
                Console.WriteLine("Leap");
            }
        }
    }
}
