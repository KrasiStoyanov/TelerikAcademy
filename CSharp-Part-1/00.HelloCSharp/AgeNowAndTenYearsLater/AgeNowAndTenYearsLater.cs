namespace AgeNowAndTenYearsLater
{
    using System;

    public class AgeNowAndTenYearsLater
    {
        public static void Main()
        {
            int currentAge = Int32.Parse(Console.ReadLine());
            int ageAfterTenYears = currentAge + 10;
            Console.WriteLine("Age now: {0}" + "\n" + "After 10 years: {1}", currentAge, ageAfterTenYears);
        }
    }
}