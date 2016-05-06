namespace BinarySearch
{
    using System;

    // Problem 11. Binary Search

    /*
     Write a program that finds the index of given element X in a sorted array of 
     N integers by using the Binary search algorithm.
    */

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] userArr = new int[n];
            for (int i = 0; i < userArr.Length; i++)
            {
                userArr[i] = int.Parse(Console.ReadLine());
            }

            int x = int.Parse(Console.ReadLine());
            int indexOfx = -1;
            Array.Sort(userArr);

            int start = 0;
            int end = userArr.Length;
            int middle;
            while (start <= end)
            {
                middle = (start + end) / 2;
                if (x == userArr[middle])
                {
                    indexOfx = middle;
                    break;
                }
                else if (x < userArr[middle])
                {
                    end = middle - 1;
                }
                else
                {
                    start = middle + 1;
                }
            }

            Console.WriteLine("{0}", indexOfx);
        }
    }
}
