using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class GSMTest
    {
        //Problem 7.GSM test
        //Write a class GSMTest to test the GSM class:
        //Create an array of few instances of the GSM class.
        //Display the information about the GSMs in the array.
        //Display the information about the static property IPhone4S.

        private GSM[] gsmCollection =
            {
            new GSM("iPhone 4S", "Apple", 700, "Petrov", new Battery("none", 50, 25, BatteryType.LiIon), new Display(4.5, 16000000)),
            new GSM("Nokia", "Nokia", 400, "Ivanov", new Battery("none", 45, 20, BatteryType.LiIon), new Display(4.0, 15000000)),
            new GSM("Samsung Galaxy", "Samsung", 650, "Georgiev", new Battery("none", 50, 25, BatteryType.LiIon), new Display(5.0, 14000000)),
            };

        public void DisplayGSMInfo()
        {
            foreach (var gsm in gsmCollection)
            {
                Console.WriteLine(gsm.ToString());
            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
