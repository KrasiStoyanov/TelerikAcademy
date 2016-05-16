namespace RemoveElementsFromArray
{
    using System;
    using System.Collections.Generic;
    // Problem 16. Remove Elements From Array

    /*
     Write a program that reads an array of integers and removes from it a minimal number of 
     elements in such a way that the remaining array is sorted in increasing order.
     Print the minimal number of elements that need to be removed in order for the array to 
     become sorted.
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

            int counter = 0;
            List<int> userList = new List<int>(userArr);
            for (int i = 0; i < userArr.Length; i++)
            {
                if (i + 1 < userArr.Length)
                {
                    if (userArr[i] > userArr[i + 1])
                    {
                        userList.Remove(userArr[i]);
                        counter++;
                    }
                }
            }

            Console.WriteLine("{0} \n\n{1}", String.Join(", ", userList), counter);
        }
    }
}
