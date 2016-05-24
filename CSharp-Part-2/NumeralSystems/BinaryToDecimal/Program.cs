namespace BinaryToDecimal
{
    using System;
    using System.Numerics;

    public class Program
    {
        private static void Main()
        {
            string n = Console.ReadLine();
            BigInteger result = BinaryToAnything(n, 2);
            Console.WriteLine(result);
        }

        static BigInteger BinaryToAnything(string binaryNumber, int baseValue)
        {
            BigInteger result = 0;
            int counter = binaryNumber.Length - 1;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                result += (binaryNumber[i] - '0') * (BigInteger)Math.Pow(baseValue, counter);
                counter--;
            }

            return result;
        }
    }
}
