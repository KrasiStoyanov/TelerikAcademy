using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{

    //Problem 8. Calls
    //Create a class Call to hold a call performed through a GSM.
    //It should contain date, time, dialled phone number and duration (in seconds).

    public class Call
    {
        public const decimal pricePerMinute = 0.37M; // Problem 12

        private string date;
        private string time;
        private int dialledNumber;
        private int duration;

        public Call(string date, DateTime dateTime, string dialletNumber, int duration)
        {
            this.Date = date;
            this.Time = dateTime.TimeOfDay.ToString();
            this.DialledNumber = dialledNumber;
            this.Duration = duration;
        }

        public string Date { get; private set; }
        public string Time { get; private set; }
        public int DialledNumber { get; private set; }
        public int Duration { get; private set; }

        public override string ToString()
        {
            return string.Format("Date: {0}, Time: {1}, GSM Dialled Phone Number: {2}, Duration: {3}",
                this.date, this.time, this.dialledNumber, this.duration);
        }
    }
}

