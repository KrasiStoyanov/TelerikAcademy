namespace SumOfFiveNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int sumOfFiveNumbers = a + b + c + d + e;
            Console.WriteLine("{0}", sumOfFiveNumbers);
        }
    }
}
