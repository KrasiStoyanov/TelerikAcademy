using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Call
    {
        private string date;
        private string time;
        private string phoneNumber;
        private int secondsInCall;

        public Call()
        {
            this.Date = "unknown";
            this.Time = "unknown";
            this.PhoneNumber = "0XXXXXXXXXX";
            this.SecondsInCall = 0;
        }
        public Call(string date, string time, string phoneNumber, int secondsInCall)
        {
            this.Date = date;
            this.Time = time;
            this.PhoneNumber = phoneNumber;
            this.SecondsInCall = secondsInCall;
        }

        public string Date { get; set; }
        public string Time { get; set; }
        public string PhoneNumber { get; set; }
        public int SecondsInCall { get; set; }



    }
}
