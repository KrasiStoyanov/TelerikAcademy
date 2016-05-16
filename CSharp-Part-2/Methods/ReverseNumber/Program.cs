namespace ReverseNumber
{
    using System;

    public class Program
    {
        public static void Main()
        {
            ReverseGivenNumber();
        }

        private static void ReverseGivenNumber()
        {
            string userNumber = Console.ReadLine();
            string result = "";
            for (int i = userNumber.Length - 1; i >= 0; i--)
            {
                result += userNumber[i];
            }

            Console.WriteLine(result);
        }
    }
}
