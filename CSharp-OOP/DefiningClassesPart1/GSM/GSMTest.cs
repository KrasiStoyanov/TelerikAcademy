namespace GSM
{
    using System;

    public class GSMTest
    {
        public static void TestGSM()
        {
            var battery = new Battery("Moqta firma za baterii", "Moqt model bateriq", 100, 150, BatteryType.LiIon);
            var display = new Display("Moqta firma za displejove", "Moqt model display", 5.6, "1900 x 600");
            var gsm = new GSM("Moqta firma", "Moqt model", battery, display, "Az sym owner", 1900);

            var gsmToString = gsm.ToString();
            Console.WriteLine(gsmToString);
        }
    }
}
