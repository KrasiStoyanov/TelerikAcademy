namespace StrangeLandNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class Program
    {
        public static Dictionary<string, int> strangeLandWords = new Dictionary<string, int>()
        {
            {"f", 0  },
            {"bIN", 1  },
            {"oBJEC", 2  },
            {"mNTRAVL", 3  },
            {"lPVKNQ", 4  },
            {"pNWE", 5  },
            {"hT", 6  }
        };

        private static void Main()
        {
            string strangeLandString = Console.ReadLine();
            BigInteger result = ToDecimal(strangeLandString, 7);
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
                if (strangeLandWords.ContainsKey(currentWord))
                {
                    sum += strangeLandWords[currentWord];
                    currentWord = "";
                }
            }

            for (int i = 0; i < sum.Length; i++)
            {
                result = (sum[i] - '0') + result * inputTypeSystem;
            }

            return result;
        }
    }
}
