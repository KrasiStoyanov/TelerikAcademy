namespace AllocateArray
{
    using System;

    // Problem 1. Allocate array

    // Write a program that allocates array of N integers, initializes each element by its index 
    // multiplied by 5 and the prints the obtained array on the console.

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
            }

            Console.WriteLine(string.Join("\n", arr));
        }
    }
}
