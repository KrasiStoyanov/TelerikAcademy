using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class Battery
    {
        //Enumeration
        enum BatteryType //"..it should be noticed, that sometimes enumeration should and can be declared within a class in order of better encapsulation of the class."
        {
            LiIon, NiMH, NiCd,
        }

        //Instance fileds
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;
        private BatteryType type;

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public int? HoursIdle
        {
            get
            {
                return hoursIdle;
            }

            set
            {
                hoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get
            {
                return hoursTalk;
            }

            set
            {
                hoursTalk = value;
            }
        }


        //Constructor
        public Battery(): this(null,null,null)
        {
        }
        public Battery(string model, int idle): this (model,idle,null)
        {
        }
        public Battery(string model, int? idle, int? hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = idle;
            this.HoursTalk = hoursTalk;
        }

        public override string ToString()
        {
            return $"\nBattery model: { this.Model} \nStand-by time: { this.HoursIdle}h  \nTalk time: { this.HoursTalk}h";
        }

    }
}
