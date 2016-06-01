namespace EvenDifferences
{
    using System;
    using System.Numerics;

    public class Program
    {
        private static void Main()
        {
            string[] sequence = Console.ReadLine().Split(' ');
            BigInteger sumOfEvenAbsoluteDifferences = 0;
            for (int i = 1; i < sequence.Length; i++)
            {
                BigInteger currentNumber = BigInteger.Parse(sequence[i]);
                BigInteger previousNumber = BigInteger.Parse(sequence[i - 1]);
                BigInteger biggerNumber = currentNumber;
                BigInteger smalleNumber = previousNumber;
                BigInteger absoluteDifference = 0;

                if (biggerNumber < smalleNumber)
                {
                    smalleNumber = currentNumber;
                    biggerNumber = previousNumber;
                }

                absoluteDifference = biggerNumber - smalleNumber;
                if (absoluteDifference % 2 == 0)
                {
                    sumOfEvenAbsoluteDifferences += absoluteDifference;
                    i++;
                }
            }

            Console.WriteLine(sumOfEvenAbsoluteDifferences);
        }
    }
}
