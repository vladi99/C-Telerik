using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Constructors
    {
        static void Main()
        {
            GSM myMobile = new GSM("Nokia", "Nokia Bulgaria");
        }

        public class GSM
        {
            private string model;
            private string manufacturer;
            private string price;
            private string owner;
            private string battery;
        
            public GSM(string model, string manufacturer, string price = null, string owner = null, string battery = null)
            {
                this.model = model;
                this.manufacturer = manufacturer;
                this.price = price;
                this.owner = owner;
                this.battery = battery;
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
            public string Battery
            {
                get { return this.battery; }
                set { this.battery = value; }
            }
        }
    }
}
