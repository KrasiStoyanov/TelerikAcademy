namespace DecimalToBinary
{
    using System;
    using System.Numerics;

    public class Program
    {
        private static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            string result = DecimalToAnything(n, 2);
            Console.WriteLine(result);
        }

        static string DecimalToAnything(BigInteger decValue, int baseValue)
        {
            string result = "";
            do
            {
                BigInteger reminder = decValue % baseValue;
                result = reminder + result;
                decValue /= baseValue;
            } while (decValue > 0);

            return result;
        }
    }
}
