namespace GetLargestNumber
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string userNumbers = Console.ReadLine();
            string[] numbersArr = userNumbers.Split(' ');
            int maxNumber = int.MinValue;
            for (int i = 0; i < numbersArr.Length; i++)
            {
                if (i + 1 < numbersArr.Length)
                {
                    int currentNumebr = GetMax(int.Parse(numbersArr[i]), int.Parse(numbersArr[i + 1]));
                    if (maxNumber < currentNumebr)
                    {
                        maxNumber = currentNumebr;
                    }
                }
            }

            Console.WriteLine(maxNumber);
        }

        private static int GetMax(int a, int b)
        {
            int max = int.MinValue;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            return max;
        }
    }
}
