namespace LeapYear
{
    using System;

    public class Program
    {
        private static void Main()
        {
            int userYear = int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(userYear))
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
