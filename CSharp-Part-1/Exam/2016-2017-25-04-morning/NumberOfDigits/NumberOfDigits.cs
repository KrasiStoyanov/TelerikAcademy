namespace NumberOfDigits
{
    using System;

    public class NumberOfDigits
    {
        public static void Main()
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int index = 1; index <= numberOfPages; index++)
            {
                string currentNumber = index.ToString();
                for (int j = 0; j < currentNumber.Length; j++)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
