namespace SumIntegers
{
    using System;

    public class Program
    {
        private static void Main()
        {
            string[] userIntegers = Console.ReadLine().Split(' ');
            int sum = 0;
            for (int i = 0; i < userIntegers.Length; i++)
            {
                int currentNumber = int.Parse(userIntegers[i]);
                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
