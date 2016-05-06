namespace MaximumSum
{
    using System;

    // Problem 8. Maximum Sum

    /*
     Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
       - Can you do it with only one loop (with single scan through the elements of the array)?
    */

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] userArr = new int[n];
            int sum = 0;
            int maxSum = int.MinValue;
            for (int i = 0; i < userArr.Length; i++)
            {
                userArr[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < userArr.Length; i++)
            {
                sum += userArr[i];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                else if (sum < 0)
                {
                    sum = 0;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
