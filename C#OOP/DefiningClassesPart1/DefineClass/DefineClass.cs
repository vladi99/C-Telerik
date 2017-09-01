using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    class DefineClass
    {
        static void Main()
        {
            GSM phone = new GSM();
        }



        public class Batery
        {
            public string Model { get; set; }

            public string HoursIdle { get; set; }

            public string HoursTalk { get; set; }
        }

        public class Display
        {
            public string Size { get; set; }

            public string Colors { get; set; }
        }
        


    }
}
