namespace SelectionSort
{
    using System;

    // Problem 7. Selection Sort

    /*
     Sorting an array means to arrange its elements in increasing order.
     Write a program to sort an array. Use the Selection sort algorithm:
       - Find the smallest element, move it at the first position, find the
         smallest from the rest, move it at the second position, etc.
    */

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] userArr = new int[n];
            int swapper = 0;
            for (int i = 0; i < userArr.Length; i++)
            {
                userArr[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < userArr.Length - 1; j++)
            {
                int min = j;
                for (int i = j + 1; i < userArr.Length; i++)
                {
                    if (userArr[i] < userArr[min])
                    {
                        min = i;
                    }
                }

                if (min != j)
                {
                    swapper = userArr[j];
                    userArr[j] = userArr[min];
                    userArr[min] = swapper;
                }
            }

            Console.WriteLine(String.Join("\n", userArr));
        }
    }
}
