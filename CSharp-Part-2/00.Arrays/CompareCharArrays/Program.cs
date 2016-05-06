namespace CompareCharArrays
{
    using System;

    // Problem 3. Compare Char Arrays

    // Write a program that compares two char arrays lexicographically (letter by letter).

    public class Program
    {
        public static void Main()
        {
            string firstStringArr = Console.ReadLine();
            string secondStringArr = Console.ReadLine();

            int result = firstStringArr.CompareTo(secondStringArr);
            if (result == -1)
            {
                Console.WriteLine("<");
            }
            else if (result == 1)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}
