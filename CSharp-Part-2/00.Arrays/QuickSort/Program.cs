namespace QuickSort
{
    using System;

    // Problem 14. Quick Sort

    // Write a program that sorts an array of integers using the Quick sort algorithm.

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

            Quicksort(userArr, 0, userArr.Length - 1);
            Console.WriteLine(string.Join("\n", userArr));
        }

        public static void Quicksort(int[] userArr, int start, int end)
        {
            int i = start;
            int j = end;
            int pivot = userArr[(start + end) / 2];

            while (i <= j)
            {
                while (userArr[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (userArr[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    int tmp = userArr[i];
                    userArr[i] = userArr[j];
                    userArr[j] = tmp;

                    i++;
                    j--;
                }
            }
            
            if (start < j)
            {
                Quicksort(userArr, start, j);
            }

            if (i < end)
            {
                Quicksort(userArr, i, end);
            }
        }
    }
}
