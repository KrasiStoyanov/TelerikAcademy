namespace SumOfNNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int index = 0; index < length; index++)
            {
                sum += double.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
