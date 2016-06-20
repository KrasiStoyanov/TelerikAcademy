using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class GSM
    {
        #region Fields
        //Static filed for iPhone
        private static GSM iPhone4S;

        //Instance fields
        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Calls> conversations;
        #endregion

        #region Constructors
        //Static constructor for iPhone
        static GSM()
        {
            iPhone4S = new GSM("iPhone4S", "Apple", 999.99, "Gosho", new Battery("Li-Po", 200, 14), new Display(3.5, 16));
        }

        //Instance constructors
        public GSM(string model, string manufacturer)
        {
            this.Model = model; //property
            this.Manufacturer = manufacturer; //property

            this.conversations = new List<Calls>();
        }

        public GSM(string model, string manufacturer, string owner) : this(model, manufacturer)
        {
            this.Owner = owner; //property
        }

        public GSM(string model, string manufacturer, double? price) : this(model, manufacturer)
        {
            this.Price = price;  //property
        }

        public GSM(string model, string manufacturer, double? price, string owner, Battery battery, Display display) : this(model, manufacturer, owner)
        {
            this.Price = price;  //property   
            this.Battery = battery; //property
            this.Display = display; //property

        }
        #endregion

        #region Properties
        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Battery model can't be empty");
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Manufacturer info can't be empty");
                }
                this.manufacturer = value;
            }
        }

        public double? Price
        {
            get
            {
                return price;
            }

            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Price cant be negative number");
                }
                price = value;
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Owner name can't be empty");
                }
                owner = value;
            }
        }

        internal Battery Battery
        {
            get
            {
                return battery;
            }

            set
            {
                battery = value;
                
            }
        }

        internal Display Display
        {
            get
            {
                return display;
            }

            set
            {
                display = value;
            }
        }

        internal static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }

            set
            {
                iPhone4S = value;
            }
        }

        public List<Calls> CallHistory
        {
            get
            {
                return conversations;
            }
        }
        #endregion


        //Overrides
        public override string ToString()
        {
            return $"Displaying information about the current item: \nModel: {this.model} \nManufacturer: {this.manufacturer} \nPhone price: {this.price} \nPhone owned by: {this.owner} \nBattery info: {this.battery} \nDisplay: {this.display} ";
        }

        #region Methods
        public void AddCall(Calls call)
        {
            this.conversations.Add(call);
        }

        public void DeleteCall(Calls call)
        {
            this.conversations.Remove(call);
        }

        public void DeleteCallHistory()
        {
            this.conversations.Clear();
        }

        public double CallsTotalPrice(double pricePerMin)
        {
            double totalPrice = 0;
            int totalSeconds = 0;
            foreach (var call in this.conversations)
            {
                totalSeconds += call.Duration;

            }
            totalPrice = totalSeconds / 60 * pricePerMin;
            return totalPrice;

        }

        public void RemoveLongestCall()
        {
            
            int longestDuration = 0;
            int longestCallPos = 0;
            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                if (this.CallHistory[i].Duration > longestDuration)
                {
                    longestDuration = this.CallHistory[i].Duration;
                    longestCallPos = i;
                }
            }

            this.CallHistory.RemoveAt(longestCallPos);
        }
        #endregion

    }
}


