namespace CompareArrays
{
    using System;
    using System.Linq;

    // Problem 2. Compare arrays

    // Write a program that reads two integer arrays of size N from the console and compares them element by element.

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] secondArr = new int[n];
            string areEqual = "Equal";
            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                firstArr[i] = currentNumber;
            }

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                secondArr[i] = currentNumber;
            }

            for (int i = 0; i < n; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    areEqual = "Not equal";
                    break;
                }
            }

            Console.WriteLine("{0}", areEqual);
        }
    }
}
