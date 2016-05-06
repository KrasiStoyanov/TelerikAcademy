namespace MergeSort
{
    using System;

    // Problem 13. Merge Sort

    // Write a program that sorts an array of integers using the Merge sort algorithm.

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

            int[] workArr = new int[userArr.Length];
            int[] result = TopDownMergeSort(userArr, workArr, n);
            Console.WriteLine(String.Join("\n", result));
        }

        public static int[] TopDownMergeSort(int[] userArr, int[] workArr, int n)
        {
            TopDownSplitMerge(userArr, 0, n, workArr);
            return userArr;
        }

        public static void TopDownSplitMerge(int[] userArr, int iBegin, int iEnd, int[] workArr)
        {
            if (iEnd - iBegin < 2) return;

            int iMiddle = (iEnd + iBegin) / 2;
            TopDownSplitMerge(userArr, iBegin, iMiddle, workArr);
            TopDownSplitMerge(userArr, iMiddle, iEnd, workArr);
            TopDownMerge(userArr, iBegin, iMiddle, iEnd, workArr);
            CopyArray(workArr, iBegin, iEnd, userArr);
        }

        public static void TopDownMerge(int[] userArr, int iBegin, int iMiddle, int iEnd, int[] workArr)
        {
            int i = iBegin;
            int j = iMiddle;
            for (int k = iBegin; k < iEnd; k++)
            {
                if (i < iMiddle && (j >= iEnd || userArr[i] <= userArr[j]))
                {
                    workArr[k] = userArr[i];
                    i = i + 1;
                }
                else {
                    workArr[k] = userArr[j];
                    j = j + 1;
                }
            }
        }

        public static void CopyArray(int[] workArr, int iBegin, int iEnd, int[] userArr)
        {
            for (int k = iBegin; k < iEnd; k++)
                userArr[k] = workArr[k];
        }
    }
}
