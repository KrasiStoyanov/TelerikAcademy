namespace FrequentNumber
{
    using System;

    // Problem 9. Frequent Number

    // Write a program that finds the most frequent number in an array of N elements.

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] userArr = new int[n];
            int counter = 1;
            int maxCounter = int.MinValue;
            int resultNumber = 0;
            for (int i = 0; i < userArr.Length; i++)
            {
                userArr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(userArr);
            for (int i = 0; i < userArr.Length; i++)
            {
                if (i + 1 < userArr.Length)
                {
                    if (userArr[i] == userArr[i + 1])
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            resultNumber = userArr[i];
                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                }
            }

            Console.WriteLine("{0} ({1} times)", resultNumber, maxCounter);
        }
    }
}
