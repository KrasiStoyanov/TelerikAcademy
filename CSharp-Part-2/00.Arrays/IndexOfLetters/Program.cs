namespace IndexOfLetters
{
    using System;

    // Problem 12. Index Of Letters

    /*
     Write a program that creates an array containing all letters from the alphabet (a-z).
     Read a word from the console and print the index of each of its letters in the array.
    */

    public class Program
    {
        public static void Main()
        {
            string userWord = Console.ReadLine();
            char[] allLetters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            for (int i = 0; i < userWord.Length; i++)
            {
                int currentIndex = Array.IndexOf(allLetters, userWord[i]);
                Console.WriteLine(currentIndex);
            }
        }
    }
}
