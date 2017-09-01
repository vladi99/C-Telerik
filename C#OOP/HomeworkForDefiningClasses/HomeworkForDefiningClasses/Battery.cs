using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkForDefiningClasses
{
    public class Battery
    {
        //problem 1
        private string batteryModel;
        private string batteryHoursIdle;
        private string batteryHoursTalk;
        private BatteryType li_lon;

        public Battery(BatteryType li_lon)
        {
            this.li_lon = li_lon;
        }

        //problem 5
        public string Model { get; set; }

        public string HoursIdle { get; set; }

        public string HoursTalk { get; set; }
    }
}
