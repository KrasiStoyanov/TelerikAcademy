using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    // Problem 1. Define class
    //Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics(model, hours idle and hours talk) and display characteristics(size and number of colors).
    //Define 3 separate classes(class GSM holding instances of the classes Battery and Display).
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private static readonly GSM iPhone4S = new GSM("iPhone 4S", "Apple", 700, "Petrov", new Battery("none", 50, 25, BatteryType.LiIon), new Display(4.5, 16000000));
        private List<Call> callHistory = new List<Call>();

        //Problem 6. Static field
        //Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.

        public static GSM IPhone4S
        {
            get
            {
                return IPhone4S;
            }
        }

        //Problem 2. Constructors
        //Define several constructors for the defined classes that take different sets of arguments(the full information for the class or part of it).
        //Assume that model and manufacturer are mandatory(the others are optional). All unknown data fill with null.

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = null;
            this.Owner = null;
            this.Battery = new Battery();
            this.Display = new Display();
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.battery = battery;
            this.display = display;
        }

        //Problem 5. Properties
        //Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
        //Ensure all fields hold correct data at any given time.

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model cannot be null or empty string!");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Manufacturer cannot be null or empty string!");
                }
                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price cannot be negative number!");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Owner cannot be null or empty string!");
                }
                this.owner = value;
            }
        }

        public Battery Battery{ get; set; }

        public Display Display { get; set; }

        //Problem 9. Call history
        //Add a property CallHistory in the GSM class to hold a list of the performed calls.
        //Try to use the system class List<Call>.

            public string CallHistory
        {
            get
            {
                if(callHistory.Count == 0)
                {
                    return "Call History is empty.";
                }

                else
                {
                    StringBuilder callInfo = new StringBuilder();

                    for(int i = 0; i < this.callHistory.Count; i++)
                    {
                        callInfo.Append(this.callHistory[i].ToString());
                        callInfo.Append("\n");
                    }

                    return callInfo.ToString();
                }
            }
        }

        //Problem 10. Add/Delete calls
        //Add methods in the GSM class for adding and deleting calls from the calls history.
        //Add a method to clear the call history.

        public void AddCall (Call call)
        {
            this.callHistory.Add(call);                
        }

        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        //Problem 11. Call price
        //Add a method that calculates the total price of the calls in the call history.
        //Assume the price per minute is fixed and is provided as a parameter.

        public decimal CallPrice(decimal pricePerMinute)
        {
            var totalSeconds = 0;

            for(int i = 0; i < this.callHistory.Count;i++)
            {
                totalSeconds += this.callHistory[i].Duration;
            }

            decimal price = totalSeconds * (pricePerMinute / 60);

            return price;
        }

        

        //Problem 4. ToString
        //Add a method in the GSM class for displaying all information about it.
        //Try to override ToString().

        public override string ToString()
        {
            return string.Format("GSM Model: {0}, GSM Manufacturer: {1}, GSM Price: {2}, GSM Owner: {3}, GSM Battery: {4}, GSM Display: {5}",
                this.model, this.manufacturer, this.price, this.owner, this.battery, this.display);
        }
    }

}
