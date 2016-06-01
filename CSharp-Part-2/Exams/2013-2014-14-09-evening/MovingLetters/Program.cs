namespace MovingLetters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        private static void Main()
        {
            string[] sequenceOfWords = Console.ReadLine().Split(' ');
            string initiallyMovedLetters = InitialMovement(sequenceOfWords);
            List<char> result = new List<char>(AlphabeticMovement(initiallyMovedLetters));
            PrintResult(result);
        }

        private static void PrintResult(List<char> result)
        {
            string finalResult = "";
            for (int i = 0; i < result.Count; i++)
            {
                finalResult += result.ElementAt(i);
            }

            Console.WriteLine(finalResult);
        }

        private static List<char> AlphabeticMovement(string initiallyMovedLetters)
        {
            List<char> sequence = new List<char>(initiallyMovedLetters.ToCharArray());
            var lengthOfSequence = sequence.Count;
            for (int i = 0; i < lengthOfSequence; i++)
            {
                var currentLetter = sequence.ElementAt(i);
                var alphabeticPosOfLetter = char.ToUpper(currentLetter) - 64;
                var nextPosition = (i + alphabeticPosOfLetter) % lengthOfSequence;
                sequence.RemoveAt(i);
                sequence.Insert(nextPosition, currentLetter);
            }

            return sequence;
        }

        private static string InitialMovement(string[] sequenceOfWords)
        {
            string result = "";
            int i = 0;
            int totalLength = 0;
            for (int j = 0; j < sequenceOfWords.Length; j++)
            {
                totalLength += sequenceOfWords[j].Length;
            }

            while (true)
            {
                StringBuilder currentWord = new StringBuilder(sequenceOfWords[i]);
                if (result.Length == totalLength)
                {
                    break;
                }

                if (currentWord.Length == 0)
                {
                    result += "";
                }
                else
                {
                    result += currentWord[currentWord.Length - 1];
                    currentWord.Remove(currentWord.Length - 1, 1);
                }

                sequenceOfWords[i] = currentWord.ToString();
                if (i == sequenceOfWords.Length - 1)
                {
                    i = 0;
                }
                else
                {
                    i++;
                }
            }

            return result;
        }
    }
}
