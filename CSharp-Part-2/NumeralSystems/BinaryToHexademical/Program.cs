namespace BinaryToHexademical
{
    using System;
    using System.Numerics;

    public class Program
    {
        private static char[] hexademicValues = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        private static void Main()
        {
            string n = Console.ReadLine();
            string result = DecimalToAnything(BinaryToAnything(n, 2), 16);
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
