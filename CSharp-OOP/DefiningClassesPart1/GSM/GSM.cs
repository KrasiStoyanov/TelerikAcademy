namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GSM
    {
        private static GSM iPhone4S = new GSM(
            "Apple", 
            "4S", 
            new Battery("Some manufacturer", "1432", 8, 200, BatteryType.LiPo), 
            new Display("Some manufacturer", "LED-backlit IPS LCD", 3.5, "640 x 960"), 
            "Krasi", 
            300);
        private List<Call> callHistory = new List<Call>();

        public GSM(string manufacturer, string model)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
        }

        public GSM(string manufacturer, string model, Battery battery)
            : this(manufacturer, model)
        {
            this.Battery = battery;
        }

        public GSM(string manufacturer, string model, Battery battery, Display display, string owner, int price)
            : this(manufacturer, model, battery)
        {
            this.Display = display;
            this.Owner = owner;
            this.Price = price;
        }

        public Display Display { get; private set; }

        public string Manufacturer { get; private set; }

        public string Model { get; private set; }

        public string Owner { get; private set; }

        public int Price { get; private set; }

        internal Battery Battery { get; private set; }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void RemoveLastCall()
        {
            this.callHistory.RemoveAt(this.callHistory.Count - 1);
        }
        
        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public double CallBill(double pricePerMinute)
        {
            int totalCallsDuration = this.callHistory.Sum(x => x.Time);
            return totalCallsDuration * pricePerMinute;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}", this.Model, this.Manufacturer, this.Owner, this.Price);
        }
    }
}
