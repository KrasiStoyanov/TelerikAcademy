namespace AppearanceCount
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            int numberToCount = int.Parse(Console.ReadLine());
            CountAppearanceOfNumber(numberToCount, numbers);
        }

        private static void CountAppearanceOfNumber(int numberToCount, string[] numbers)
        {
            int counter = 0;
            for (int index = 0; index < numbers.Length; index++)
            {
                int currentNumber = int.Parse(numbers[index]);
                if (currentNumber == numberToCount)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
