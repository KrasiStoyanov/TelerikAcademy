namespace GravitationOnTheMoon
{
    using System;

    public class GravitationOnTheMoon
    {
        public static void Main()
        {
            double weightOnEarth = double.Parse(Console.ReadLine());
            double graviationFieldOnTheMoon = 17 / 100d;
            double weightOnTheMoon = weightOnEarth * graviationFieldOnTheMoon;

            Console.WriteLine("{0:F3}", weightOnTheMoon);
        }
    }
}
