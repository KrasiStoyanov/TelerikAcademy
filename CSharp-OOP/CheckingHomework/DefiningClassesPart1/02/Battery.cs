using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }
    public class Battery
    {
        
        private int? hoursIdle;
        private int? hoursTalk;
        private BatteryType batteryType;


        public Battery()
        {
            this.hoursIdle = 0;
            this.hoursTalk = 0;
            this.batteryType = BatteryType.LiIon;
        }

        public Battery(BatteryType batteryType, int hoursIdle, int hoursToTalk)
        {
            this.BatteryType = batteryType;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursToTalk;
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
        public int? HoursIdle { get; set; }
        public int? HoursTalk { get; set; }

    }
}
