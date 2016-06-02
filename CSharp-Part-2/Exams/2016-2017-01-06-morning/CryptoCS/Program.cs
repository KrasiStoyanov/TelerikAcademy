namespace CryptoCS
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class Program
    {
        public static Dictionary<char, BigInteger> twentySixthNumeralSystemValues = new Dictionary<char, BigInteger>()
        {
            { 'a', 0  },
            { 'b', 1  },
            { 'c', 2  },
            { 'd', 3  },
            { 'e', 4  },
            { 'f', 5  },
            { 'g', 6  },
            { 'h', 7  },
            { 'i', 8  },
            { 'j', 9  },
            { 'k', 10 },
            { 'l', 11 },
            { 'm', 12 },
            { 'n', 13 },
            { 'o', 14 },
            { 'p', 15 },
            { 'q', 16 },
            { 'r', 17 },
            { 's', 18 },
            { 't', 19 },
            { 'u', 20 },
            { 'v', 21 },
            { 'w', 22 },
            { 'x', 23 },
            { 'y', 24 },
            { 'z', 25 },
            { '0', 0  },
            { '1', 1  },
            { '2', 2  },
            { '3', 3  },
            { '4', 4  },
            { '5', 5  },
            { '6', 6  },
            { '7', 7  },
            { '8', 8  }
        };

        public static Dictionary<BigInteger, char> intoAnything = new Dictionary<BigInteger, char>()
        {
            { 0,  '0' },
            { 1,  '1' },
            { 2,  '2' },
            { 3,  '3' },
            { 4,  '4' },
            { 5,  '5' },
            { 6,  '6' },
            { 7,  '7' },
            { 8,  '8' },
            { 9,  '9' },
            { 10, 'A' },
            { 11, 'B' },
            { 12, 'C' },
            { 13, 'D' },
            { 14, 'E' },
            { 15, 'F' }
        };

        private static void Main()
        {
            string userWord = Console.ReadLine();
            BigInteger wordInDecimal = ToDecimal(userWord, 26);

            char operation = char.Parse(Console.ReadLine());
            BigInteger userNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger numberInDecimal = ToDecimal(userNumber.ToString(), 7);

            BigInteger operationResult = 0;
            if (operation == '+')
            {
                operationResult = wordInDecimal + numberInDecimal;
            }
            else
            {
                operationResult = wordInDecimal - numberInDecimal;
            }

            string result = DecToAnything(operationResult, 9);
            Console.WriteLine(result);
        }

        static string DecToAnything(BigInteger input, int outputBase)
        {
            string result = "";
            do
            {
                BigInteger reminder = input % outputBase;
                result = intoAnything[reminder] + result;
                input /= outputBase;
            } while (input > 0);

            return result;
        }

        public static BigInteger ToDecimal(string input, int inputBase)
        {
            BigInteger result = 0;
            foreach (char symbol in input)
            {
                result = twentySixthNumeralSystemValues[symbol] + result * inputBase;
            }

            return result;
        }
    }
}
