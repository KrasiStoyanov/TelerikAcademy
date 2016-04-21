namespace ThreeNumbers
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int[] arr = { a, b, c };
            int min = arr.Min();
            int max = arr.Max();
            double average = arr.Average();

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine("{0:F2}", average);
        }
    }
}
