namespace Zerg
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    public class Program
    {
        private static Dictionary<string, int> messages = new Dictionary<string, int>()
        {
            { "Rawr", 0 },
            { "Rrrr", 1 },
            { "Hsst", 2 },
            { "Ssst", 3 },
            { "Grrr", 4 },
            { "Rarr", 5 },
            { "Mrrr", 6 },
            { "Psst", 7 },
            { "Uaah", 8 },
            { "Uaha", 9 },
            { "Zzzz", 10 },
            { "Bauu", 11 },
            { "Djav", 12 },
            { "Myau", 13 },
            { "Gruh", 14 },
        };

        private static Dictionary<int, char> fifteenthNumeralSystem = new Dictionary<int, char>()
        {
            { 0, '0' },
            { 1, '1' },
            { 2, '2' },
            { 3, '3' },
            { 4, '4' },
            { 5, '5' },
            { 6, '6' },
            { 7, '7' },
            { 8, '8' },
            { 9, '9' },
            { 10, 'A' },
            { 11, 'B' },
            { 12, 'C' },
            { 13, 'D' },
            { 14, 'E' },
        };

        private static Dictionary<char, int> reversedFifteenthNumeralSystem = new Dictionary<char, int>()
        {
            { '0', 0 },
            { '1', 1 },
            { '2', 2 },
            { '3', 3 },
            { '4', 4 },
            { '5', 5 },
            { '6', 6 },
            { '7', 7 },
            { '8', 8 },
            { '9', 9 },
            { 'A', 10 },
            { 'B', 11 },
            { 'C', 12 },
            { 'D', 13 },
            { 'E', 14 },
        };

        private static void Main()
        {
            string strangeLandString = Console.ReadLine();
            BigInteger result = ToDecimal(strangeLandString, 15);
            Console.WriteLine(result);
        }

        private static BigInteger ToDecimal(string strangeLandString, int inputTypeSystem)
        {
            BigInteger result = 0;
            string currentWord = "";
            string sum = "";
            for (int i = 0; i < strangeLandString.Length; i++)
            {
                currentWord += strangeLandString[i];
                if (messages.ContainsKey(currentWord))
                {
                    sum += fifteenthNumeralSystem[messages[currentWord]];
                    currentWord = "";
                }
            }

            for (int i = 0; i < sum.Length; i++)
            {
                result = reversedFifteenthNumeralSystem[sum[i]] + result * inputTypeSystem;
            }

            return result;
        }
    }
}
