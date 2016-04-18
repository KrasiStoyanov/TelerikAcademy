namespace NumberComparer
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double greaterNumber = a > b ? a : b;
            Console.WriteLine("{0}", greaterNumber);
        }
    }
}
