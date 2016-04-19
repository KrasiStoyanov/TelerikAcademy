namespace TextToNumber
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int module = int.Parse(Console.ReadLine());
            string userInput = Console.ReadLine();
            long result = 0;

            userInput = userInput.ToLower();
            for (int index = 0; index < userInput.Length; index++)
            {
                char currentChar = userInput[index];
                if (currentChar == '@')
                {
                    break;
                }

                if (currentChar - '0' >= 0 && currentChar - '0' <= 9)
                {
                    result *= currentChar - '0';
                }
                else if ((int)currentChar >= 97 && (int)currentChar <= 122)
                {
                    result += currentChar - 'a';
                }
                else
                {
                    result = result % module;
                }
            }

            Console.WriteLine(result);
        }
    }
}
