namespace Printing
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double s = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double totalNumberOfRealms = (n * s) / 500;
            double result = p * totalNumberOfRealms;
            Console.WriteLine("{0:F2}", result);
        }
    }
}
