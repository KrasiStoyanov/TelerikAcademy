using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{

    public class GSM
    {
        public static GSM iPhone4S = 
                new GSM("Iphone 4S", "Apple", 400, "Pesho", 
                new Battery(BatteryType.NiMH, 250, 14), 
                new Display(5, "16m"));
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        public GSM()
        {
            this.model = "Standart";
            this.manufacturer = "China";
            this.price = 20;
            this.owner = "unknown";
            this.Battery = battery;
            this.Display = display;
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = null;
            this.Owner = null;
            this.battery = null;
            this.display = null;
            this.callHistory = new List<Call>();

        }

        public GSM(string model, string manufacturer, decimal? price, string owner , Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal? Price { get; set; }
        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        public void AllInfo()
        {
            var gsmInfo = "Model: " + this.Model
                + "\nManufacturer: " + this.Manufacturer
                + "\nPrice: " + this.Price
                + "\nOwner: " + this.Owner
                + "\nBattery: " + this.Battery.BatteryType + " Stand-by:" + this.Battery.HoursIdle + " Talk time:" + this.Battery.HoursTalk
                + "\nDisplay: " + this.Display.Color + " Size:" + this.Display.Size
                + "\n----------------------------------------------"
                + "\n" ;

            Console.WriteLine(string.Join("", gsmInfo)); ;
        }

        public void AddCall(string date, string time, string phoneNumber, int duration)
        {
            this.callHistory.Add(new Call(date, time, phoneNumber, duration));
        }

        public void DeleteCall(Call call)
        {           
            this.callHistory.Remove(call);
        }

        public void PrintHistory()
        {

                foreach (var call in callHistory)
                {
                    Console.WriteLine(call.Date + " "+ call.Time + " : call from " + call.PhoneNumber + " " + call.SecondsInCall + "s");
                }            
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public double TotalCallPrice(double price)
        {
            double totalDuration = 0;
            foreach (var call in this.callHistory)
            {
                totalDuration += call.SecondsInCall / 60;
            }
            return totalDuration * price;
        }


        public void RemoveLongestCall()
        {
            List<Call> longestCall = callHistory.OrderBy(x => x.SecondsInCall).ToList();
            longestCall.RemoveAt(longestCall.Count - 1);
            double totalDuration = 0;
            foreach (var call in longestCall)
            {
                totalDuration += call.SecondsInCall / 60;
            }
            Console.WriteLine("Without longest call: " + totalDuration * 0.37);
        }

    }
}


/*
 
            public void AddCall(DateTime date,string phoneNumber, int secondsInCall)
        {
            this.CallHistory.Add(new Call(date, phoneNumber, secondsInCall));
        }

        public List<Call> DeleteCall(Call currentCall)
        {
            this.callHistory.Remove(currentCall);
            return new List<Call>(this.callHistory);
        }

        public List<Call> DeleteCallHistory()
        {
            this.callHistory.Clear();
            return new List<Call>(this.callHistory);

        }

        public double CallsPrice(double price)
        {            
            double sum = 0;
            var duration = 0;
            foreach (var call in this.callHistory)
            {
                duration += call.SecondsInCall / 60;
            }
            sum = duration * price;
            return sum;
        }






    */
