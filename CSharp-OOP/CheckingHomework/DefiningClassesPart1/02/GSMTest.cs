using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class GSMTest
    {
        

        public static void GSMPrinting()
        {
            GSM[] phoneArray =
            {
                new GSM("Iphone 6S", "Apple", 1800, "Nikki", new Battery(BatteryType.NiCd, 72, 48), new Display(5, "250k")),
                new GSM("Galaxy S7", "Samsung", 1600, "Boris", new Battery(BatteryType.LiIon, 48, 24), new Display(7, "250k")),
                new GSM("Galaxy Note 5", "Samsung", 1200, "Stefan", new Battery(BatteryType.LiIon, 60, 36), new Display( 6, "250k"))
            };

            for (int i = 0; i < phoneArray.Length ; i++)
            {
                phoneArray[i].AllInfo();
            }

            GSM.iPhone4S.AllInfo();
        }
    }
}
