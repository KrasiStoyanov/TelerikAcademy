namespace GSM
{
    public class Battery
    {
        private BatteryType batteryType;
        
        public Battery(string manufacturer, string model, short hoursTalk, short hoursIdle, BatteryType batteryType)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.HoursTalk = hoursTalk;
            this.HoursIdle = hoursIdle;
            this.BatteryType = batteryType;
        }

        public BatteryType BatteryType { get; private set; }

        public short HoursIdle { get; private set; }

        public short HoursTalk { get; private set; }

        public string Manufacturer { get; private set; }

        public string Model { get; private set; }
    }
}
