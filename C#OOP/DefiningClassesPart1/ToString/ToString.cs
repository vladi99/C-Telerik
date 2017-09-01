using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToString
{
    class ToString
    {
        static void Main()
        {
            GSM myMobile = new GSM("Nokia", "Nokia China", "20lv", "Pesho", BatteryType.NiCd);
            myMobile.PrintInformation();


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

            //https://softuni.bg/trainings/resources/video/4583/video-1-june-2015-nakov-oop-june-2015

            public override string ToString()
            {
                return string.Format();
            }
            public void PrintInformation()
            {
                Console.WriteLine("Name: {0}", this.model);
                Console.WriteLine("Manufacturer: {0}", this.manufacturer);
                Console.WriteLine("Price: {0}", this.price);
                Console.WriteLine("Owner: {0}", this.owner);
                Console.WriteLine("Battery: {0}", this.batteryType);
            }
        }

    }
}
