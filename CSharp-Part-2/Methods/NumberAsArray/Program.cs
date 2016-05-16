namespace NumberAsArray
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] lengthsOfArrays = Console.ReadLine().Split(' ');
            int lengthOfFirstArray = int.Parse(lengthsOfArrays[0]);
            int lengthOfSecondArray = int.Parse(lengthsOfArrays[1]);
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');

            int n = GetBiggerNumber(lengthOfFirstArray, lengthOfSecondArray);
            PrintSumOfDigits(n, firstArr, secondArr);
        }

        private static int GetBiggerNumber(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }

        private static void PrintSumOfDigits(int n, string[] firstArr, string[] secondArr)
        {
            int counter = 0;
            int sum = 0;
            int[] resultArr = new int[n];
            int currentNumberFromFirstArr = 0;
            int currentNumberFromSecondArr = 0;
            for (int i = 0; i < n; i++)
            {
                if (i < firstArr.Length)
                {
                    currentNumberFromFirstArr = int.Parse(firstArr[i]);
                }
                else
                {
                    currentNumberFromFirstArr = 0;
                }

                if (i < secondArr.Length)
                {

                    currentNumberFromSecondArr = int.Parse(secondArr[i]);
                }
                else
                {
                    currentNumberFromSecondArr = 0;
                }

                sum = currentNumberFromFirstArr + currentNumberFromSecondArr + counter;
                counter = 0;
                if (sum > 9)
                {
                    counter = sum / 10;
                }

                resultArr[i] = sum % 10;
            }

            Console.WriteLine(String.Join(" ", resultArr));
        }
    }
}
