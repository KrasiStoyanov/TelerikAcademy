namespace PrimeNumbers
{
    using System;
    using System.Collections.Generic;

    // Problem 15. Prime Numbers

    /*
     Write a program that finds all prime numbers in the range [1 ... N].
     Use the Sieve of Eratosthenes algorithm.
     The program should print the biggest prime number which is <= N.
    */

    public class Program
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            bool[] booleanArr = new bool[n];
            for (int i = 2; i < n; i++)
            {
                booleanArr[i] = true;
            }

            int[] arr = new int[booleanArr.Length];
            int count = 2;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = count;
                count += 1;
            }

            for (int i = 2; i < n; i++)
            {
                if (booleanArr[i])
                {
                    for (long j = 2; (i * j) < n; j++)
                    {
                        booleanArr[i * j] = false;
                    }
                }
            }

            List<int> resultList = new List<int>();
            for (int i = 2; i < n; i++)
            {
                if (booleanArr[i])
                {
                    resultList.Add(i);
                }
            }

            Console.WriteLine(resultList[resultList.Count - 1]);
        }
    }
}
