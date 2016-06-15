namespace GSM
{
    public class Call
    {
        public Call(string date, int time, string dialedPhone)
        {
            this.Date = date;
            this.Time = time;
            this.DialedPhone = dialedPhone;
        }

        public string Date { get; private set; }

        public string DialedPhone { get; private set; }

        public int Time { get; private set; }
    }
}
