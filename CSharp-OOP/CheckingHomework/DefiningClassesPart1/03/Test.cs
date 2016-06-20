using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class Test
    {


        static void Main()
        {

            GSM firstPhone = new GSM("HTC 10", "HTC Corporation");
            GSM secondPhone = new GSM("Y6", "Huawei", "Pesho");
            GSM thirdPhone = new GSM("Nexus 5X", "LG", 1050.99, "Ivan", new Battery("abc", 24, 35), new Display(4, 255));

            //Create an array of few instances of the GSM class.
            GSM[] gsmCollection = { firstPhone, secondPhone, thirdPhone };

            //Display the information about the GSMs in the array.
            foreach (var phone in gsmCollection)
            {
                Console.WriteLine(phone);
                Console.WriteLine();
            }

            //Display the information about the static property IPhone4S.
            Console.WriteLine(GSM.IPhone4S);
            Console.WriteLine();

            //Create an instance of the GSM class.
            GSM phoneOne = new GSM("Galaxy S4", "Samsung", 450.99, "M", new Battery("LiIon", 100), new Display(5.0, 16));

            //Add few calls.

            Console.WriteLine("Call a number and enter the duration of the call on the seocnd line (in seconds)");
            phoneOne.AddCall(new Calls(Console.ReadLine(),int.Parse(Console.ReadLine())));
            Console.WriteLine("Call a number");           
            phoneOne.AddCall(new Calls(Console.ReadLine(),int.Parse(Console.ReadLine())));
            Console.WriteLine("Call a number");           
            phoneOne.AddCall(new Calls(Console.ReadLine(),int.Parse(Console.ReadLine())));
            Console.WriteLine("Call a number");           
            phoneOne.AddCall(new Calls(Console.ReadLine(),int.Parse(Console.ReadLine())));
            Console.WriteLine("Call a number");           
            phoneOne.AddCall(new Calls(Console.ReadLine(),int.Parse(Console.ReadLine())));
                                                                                        
            // Display the information about the calls.
            foreach (var call in phoneOne.CallHistory)
            {

                Console.WriteLine($"Date and time of call {call.Date.ToShortDateString()} at {string.Format("{0}:{1}:{2}", call.Time.Hours, call.Time.Minutes, call.Time.Minutes)}. Called number: {call.DailedNum}. Call duration {call.Duration/60d:F3} min.");
            }

            double pricePerMin = 0.37;

            Console.WriteLine("The price of total calls is {0} BGN", phoneOne.CallsTotalPrice(pricePerMin));

            phoneOne.RemoveLongestCall();

            Console.WriteLine("The price of total calls is {0} BGN", phoneOne.CallsTotalPrice(pricePerMin));

            //Finally clear the call history and print it.
            phoneOne.DeleteCallHistory();

        }

        

    }
}
