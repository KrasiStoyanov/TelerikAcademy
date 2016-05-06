namespace MaximalKSum
{
    using System;

    // Problem 6. Maximal K Sum

    // Write a program that reads two integer numbers N and K and an array of 
    // N elements from the console. Find the maximal sum of K elements in the array.

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] userArr = new int[n];
            int counter = 0;
            int result = 0;
            for (int i = 0; i < userArr.Length; i++)
            {
                userArr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(userArr);
            for (int i = userArr.Length - 1; i >= 0; i--)
            {
                if (counter != k)
                {
                    result += userArr[i];
                    counter++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("{0}", result);
        }
    }
}
