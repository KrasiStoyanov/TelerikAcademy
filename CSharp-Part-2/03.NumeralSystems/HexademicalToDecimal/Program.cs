namespace HexademicalToDecimal
{
    using System;
    using System.Numerics;

    public class Program
    {
        private static void Main()
        {
            string n = Console.ReadLine();
            BigInteger result = HexademicalToAnything(n, 16);
            Console.WriteLine(result);
        }

        static BigInteger HexademicalToAnything(string hexademicNumber, int baseValue)
        {
            BigInteger result = 0;
            int counter = hexademicNumber.Length - 1;
            for (int i = 0; i < hexademicNumber.Length; i++)
            {
                int currentNumber = 0;
                switch (hexademicNumber[i])
                {
                    case 'A':
                        currentNumber = 10;
                        break;
                    case 'B':
                        currentNumber = 11;
                        break;
                    case 'C':
                        currentNumber = 12;
                        break;
                    case 'D':
                        currentNumber = 13;
                        break;
                    case 'E':
                        currentNumber = 14;
                        break;
                    case 'F':
                        currentNumber = 15;
                        break;
                    default:
                        currentNumber = hexademicNumber[i] - '0';
                        break;
                }

                result += currentNumber * (BigInteger)Math.Pow(baseValue, counter);
                counter--;
            }

            return result;
        }
    }
}
