namespace FirstLargerThanNeighbours
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            findFirstBiggerThanNeighboursNumber(numbers);
        }

        private static void findFirstBiggerThanNeighboursNumber(string[] numbers)
        {
            int index = -1;
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                int previousNumber = int.Parse(numbers[i - 1]);
                int currentNumber = int.Parse(numbers[i]);
                int nextNumber = int.Parse(numbers[i + 1]);
                if (currentNumber > previousNumber && currentNumber > nextNumber)
                {
                    index = i;
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}
