namespace VariableInHex
{
    using System;

    public class VariableInHex
    {
        public static void Main()
        {
            int number = 254;
            string numberToHex = number.ToString("X");
            Console.WriteLine("0x" + numberToHex);
        }
    }
}
