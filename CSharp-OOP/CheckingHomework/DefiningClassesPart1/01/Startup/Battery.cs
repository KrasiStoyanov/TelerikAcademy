using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{

    //Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

    public class Battery
    {
        private string batteryModel;
        private int? hoursIdle;
        private int? hoursTalk;
        private BatteryType batteryType;

        //Problem 2. Constructors
        //Define several constructors for the defined classes that take different sets of arguments(the full information for the class or part of it).
        //Assume that model and manufacturer are mandatory(the others are optional). All unknown data fill with null.

        public Battery()
        {
            this.BatteryModel = null;
            this.HoursIdle = null;
            this.HoursTalk = null;
            this.BatteryType = BatteryType.LiIon;
        }

        public Battery(string batteryModel, int? hoursIdle, int? hoursTalk, BatteryType batteryType)
        {
            this.BatteryModel = batteryModel;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        //Problem 5. Properties
        //Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
        //Ensure all fields hold correct data at any given time.

        //Problem 4. ToString
        //Add a method in the GSM class for displaying all information about it.
        //Try to override ToString().

        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Battery Model cannot be null or empty string!");
                }
                this.batteryModel = value;
            }
        }

        public int? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Hours Idle canot be negative number!");
                }

                this.hoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hours Talk canot be negative number!");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Battery Model: {0}, Battery Hours Idle: {1}, Battery Hours Talk: {2}, Battery Type: {3}",
                this.batteryModel, this.hoursIdle, this.hoursTalk, this.batteryType);
        }
    }
}
