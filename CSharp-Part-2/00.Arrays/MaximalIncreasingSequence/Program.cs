namespace MaximalIncreasingSequence
{
    using System;

    // Problem 5. Maximal Increasing Sequence

    // Write a program that finds the length of the maximal increasing sequence in an array of N integers.

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] userArr = new int[n];
            int counter = 1;
            int maxCounter = -1;
            for (int i = 0; i < userArr.Length; i++)
            {
                userArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < userArr.Length; i++)
            {
                if (i + 1 < userArr.Length)
                {
                    if (userArr[i] < userArr[i + 1])
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                }
            }

            Console.WriteLine("{0}", maxCounter);
        }
    }
}
