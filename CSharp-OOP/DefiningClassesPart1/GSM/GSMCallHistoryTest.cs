namespace GSM
{
    using System;

    public class GSMCallHistoryTest
    {
        public static void TestCallHistory()
        {
            var battery = new Battery("Moqta firma za baterii", "Moqt model bateriq", 100, 150, BatteryType.LiIon);
            var display = new Display("Moqta firma za displejove", "Moqt model display", 5.6, "1900 x 600");
            var gsm = new GSM("Moqta firma", "Moqt model", battery, display, "Az sym owner", 1900);
            for (int i = 0; i < 10; i++)
            {
                gsm.AddCall(new Call(DateTime.Now.ToString(), i, "087830" + i));
            }

            gsm.RemoveLastCall();
            Console.WriteLine(gsm.CallBill(1));
            gsm.ClearCallHistory();
            Console.WriteLine(gsm.CallBill(1));
        }
    }
}
