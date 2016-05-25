namespace LargerThanNeighbours
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            countLargerNeighbours(numbers);
        }

        private static void countLargerNeighbours(string[] numbers)
        {
            int counter = 0;
            for (int index = 1; index < numbers.Length - 1; index++)
            {
                int previousNumber = int.Parse(numbers[index - 1]);
                int currentNumber = int.Parse(numbers[index]);
                int nextNumber = int.Parse(numbers[index + 1]);
                if (currentNumber > previousNumber && currentNumber > nextNumber)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
