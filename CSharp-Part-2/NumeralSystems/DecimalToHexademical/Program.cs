namespace DecimalToHexademical
{
    using System;
    using System.Numerics;

    public class Program
    {
        private static char[] hexademicValues = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        private static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            string result = DecimalToAnything(n, 16);
            Console.WriteLine(result);
        }

        static string DecimalToAnything(BigInteger decValue, int baseValue)
        {
            string result = "";
            do
            {
                BigInteger reminder = decValue % baseValue;
                result = hexademicValues[(int)reminder] + result;
                decValue /= baseValue;
            } while (decValue > 0);

            return result;
        }
    }
}
