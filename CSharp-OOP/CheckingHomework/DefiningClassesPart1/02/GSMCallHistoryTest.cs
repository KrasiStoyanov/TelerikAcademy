using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class GSMCallHistoryTest
    {

        public static void CallHistory()
        {
            GSM callTest = new GSM();
            callTest.Owner = "Pesho";

            callTest.AddCall("June 5th", "05:00am","088888888", 60);
            callTest.AddCall("June 6th", "06:00am", "088888888", 180);
            callTest.AddCall("June 7th", "07:00am", "088888888", 60);
            callTest.AddCall("June 8th", "08:00am", "088888888", 60);

            callTest.PrintHistory();
            Console.WriteLine("Total price: " + callTest.TotalCallPrice(0.37));      
            callTest.RemoveLongestCall();


            //callTest.AddCall(new Call("11th June", "11pm", "0888888888", 55));
            //callTest.AddCall(new Call("12 June", "12pm" , "0888888888", 120));
        }

    }
}


/*
 * 
callTest.AddCall(new DateTime(2016, 6, 6, 12, 35, 10), "0888888888", 360);
callTest.AddCall(new DateTime(2016, 6, 6, 12, 35, 10), "0888888888", 160);
callTest.AddCall(new DateTime(2016, 7, 6, 20, 10, 32), "0888888888", 60);

Console.WriteLine("Call history:");
Console.WriteLine(callTest.CallHistory);
Console.WriteLine("Price for calls:");
Console.WriteLine( callTest.CallsPrice(0.30));
callTest.RemoveLongestCall();
Console.WriteLine("Price after removed longest call:");
Console.WriteLine("${0:F2}", callTest.GetPrice());

callTest.ClearHistory();
Console.WriteLine(callTest.CallHistory);
*/
