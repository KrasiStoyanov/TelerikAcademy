namespace CalculationProblem
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        private static void Main()
        {
            string sequence = Console.ReadLine();
            int resultNumber = ToDecimal(sequence, 23);
            string resultString = ToNormal(resultNumber, 23);
            Console.WriteLine("{0} = {1}", resultString, resultNumber);
        }

        public static int ToDecimal(string input, int inputSystem)
        {
            int sum = 0;
            int counter = 0;

            // Reverse user string
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string sequence = new string(charArray);

            foreach (char symbol in sequence)
            {
                if (symbol != ' ')
                {
                    sum += fromThisNumeralSystemValues[symbol] * (int)Math.Pow(inputSystem, counter);
                    counter++;
                }
                else
                {
                    counter = 0;
                }
            }

            return sum;
        }

        public static string ToNormal(int sum, int inputSystem)
        {
            string result = "";
            do
            {
                int reminder = (int)sum % inputSystem;
                result = toThisNumeralSystemValues[reminder] + result;
                sum /= inputSystem;
            } while (sum > 0);

            return result;
        }

        public static Dictionary<char, int> fromThisNumeralSystemValues = new Dictionary<char, int>()
        {
            { 'a', 0 },
            { 'b', 1 },
            { 'c', 2 },
            { 'd', 3 },
            { 'e', 4 },
            { 'f', 5 },
            { 'g', 6 },
            { 'h', 7 },
            { 'i', 8 },
            { 'j', 9 },
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
            { 'w', 22 }
        };

        public static Dictionary<int, char> toThisNumeralSystemValues = new Dictionary<int, char>()
        {
            { 0, 'a' },
            { 1, 'b' },
            { 2, 'c' },
            { 3, 'd' },
            { 4, 'e' },
            { 5, 'f' },
            { 6, 'g' },
            { 7, 'h' },
            { 8, 'i' },
            { 9, 'j' },
            { 10, 'k' },
            { 11, 'l' },
            { 12, 'm' },
            { 13, 'n' },
            { 14, 'o' },
            { 15, 'p' },
            { 16, 'q' },
            { 17, 'r' },
            { 18, 's' },
            { 19, 't' },
            { 20, 'u' },
            { 21, 'v' },
            { 22, 'w' }
        };
    }
}
