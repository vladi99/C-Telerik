using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkForDefiningClasses
{
    public class StartUp
    {
        private static void Main()
        {
            GSM gsm = new GSM("Nokia", "Asha", "Pesho", "Pesho", new Battery(BatteryType.Li_lon), new Display("12,4", "175K"));
            Console.WriteLine(gsm);
            
        }
    }
}
