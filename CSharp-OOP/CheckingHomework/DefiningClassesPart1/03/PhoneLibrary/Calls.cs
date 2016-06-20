using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class Calls
    {
        private DateTime date;
        private TimeSpan time;
        private string dailedNum;
        private int duration;

        public DateTime Date
        {
            get
            {
                return date;
            }
           private set
            {
                this.date = value;
            }

        }

        public TimeSpan Time
        {
            get
            {
                return time;
            }
            private set
            {
                this.time = value;
            }

        }

        public string DailedNum
        {
            get
            {
                return dailedNum;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.dailedNum = value;
            }

        }

        public int Duration
        {
            get
            {
                return duration;
            }

            private set
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.duration = value;
            }

        }

        public Calls(string dailedNum, int duration)
        {
            this.Date = DateTime.Now.Date;
            this.Time = DateTime.Now.TimeOfDay;
            this.DailedNum = dailedNum;
            this.Duration = duration;
        }

        
    }
}
