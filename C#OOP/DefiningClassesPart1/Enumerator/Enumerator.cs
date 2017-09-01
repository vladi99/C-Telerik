using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerator
{
    class Enumerator
    {
        static void Main()
        {
            GSM myMobile = new GSM("Nokia", "Nokia China", null, null, BatteryType.NiCd);
            Console.WriteLine(myMobile.BatteryType);
            
            
        }
        public enum BatteryType
        {
            None = 0,
            Lilon,
            NiMh,
            NiCd
        }
        public class GSM
        {
            private string model;
            private string manufacturer;
            private string price;
            private string owner;
            private BatteryType batteryType;

            public GSM(string model, string manufacturer, string price = null, string owner = null, BatteryType batteryType = 0)
            {
                this.model = model;
                this.manufacturer = manufacturer;
                this.price = price;
                this.owner = owner;
                this.batteryType = batteryType;
            }
            public string Model
            {
                get { return this.model; }
                set { this.model = value; }
            }
            public string Manufacturer
            {
                get { return this.manufacturer; }
                set { this.manufacturer = value; }
            }
            public string Price
            {
                get { return this.price; }
                set { this.price = value; }
            }
            public string Owner
            {
                get { return this.owner; }
                set { this.owner = value; }
            }
            public BatteryType BatteryType
            {
                get { return this.batteryType; }
                set { this.batteryType = value; }
            }
        }

    }
}
