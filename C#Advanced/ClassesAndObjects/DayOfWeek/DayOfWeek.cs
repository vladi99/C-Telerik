using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Parse(Console.ReadLine());
            var dayOfWeek = date.DayOfWeek;
            Console.WriteLine(dayOfWeek);
        }
    }
}
