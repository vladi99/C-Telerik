using System.Collections.Generic;
using System.Text;

namespace HomeworkForDefiningClasses
{
    public class GSM
    {
        //problem 1
        private string model;
        private string manufacturer;
        private string price;
        private string owner;
        private Battery battery;
        private Display display;

        private List<Call> callHistory = new List<Call>();

        //problem 2
        public GSM(string model, string manufacturer, string price = null, string owner = null, Battery battery = null, Display display = null)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;            
        }

        //problem 5 
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
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        //problem 4
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Model name: {0}", this.Model));
            sb.AppendLine(string.Format("Manufacturer: {0}", this.Manufacturer));
            sb.AppendLine(string.Format("Battery hourse on idle: {0}", this.Battery.HoursIdle));
            sb.AppendLine(string.Format("Battery hourse on talk: {0}", this.Battery.HoursTalk));
            sb.AppendLine(string.Format("Display size: {0}", this.Display.Size));
            sb.AppendLine(string.Format("Display colors: {0}", this.Display.Colors));
            return sb.ToString();
        }

        //problem 6
        public static string IPhone4S = "The iPhone 4S is a smartphone that was designed and marketed by Apple Inc.";

        //problem 9

        public List<Call> CallHistory
        {
            get{ return this.callHistory; }
        }

        //problem 10

        public void AddCalls(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCalls(Call call)
        {
            int index = callHistory.IndexOf(call);
            if (index != -1)
            {
                this.callHistory.RemoveAt(index);
            }
        }

        public void ClearCallHistory()
        {
            this.callHistory = new List<Call>();
        }

        //problem 11

        public double CalculateTotalPrice(double pricePerMinute)
        {
            double spentMoney = 0.0;
            double entireDuration = 0.0;
            for (int i = 0; i < CallHistory.Count; i++)
            {
                entireDuration += CallHistory[i].Duration;
            }
            spentMoney += (entireDuration * pricePerMinute);
            return spentMoney;
        }


    }
}