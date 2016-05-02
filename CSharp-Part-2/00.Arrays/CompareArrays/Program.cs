namespace CompareArrays
{
    using System;
    using System.Linq;

    // Problem 2. Compare arrays

    // Write a program that reads two integer arrays from the console and compares them element by element.

    public class Program
    {
        public static void Main()
        {
            int[] firstArr = Console.ReadLine().Split(' ').Select(character => int.Parse(character)).ToArray();
            int[] secondArr = Console.ReadLine().Split(' ').Select(character => int.Parse(character)).ToArray();
        }
    }
}
