namespace NFactorial
{
    using System;
    using System.Numerics;

    public class Program
    {
        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] sequence = new int[n];
            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = i + 1;
            }

            BigInteger resultNumber = CalculateFactorial(sequence);
            Console.WriteLine(resultNumber);
        }

        private static BigInteger CalculateFactorial(int[] sequence)
        {
            BigInteger resultNumber = 1;
            for (int i = 0; i < sequence.Length; i++)
            {
                resultNumber *= sequence[i];
            }

            return resultNumber;
        }
    }
}
