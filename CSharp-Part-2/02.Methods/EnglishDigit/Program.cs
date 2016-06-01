namespace EnglishDigit
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            ConvertToEnglishWord(number);
        }

        private static void ConvertToEnglishWord(int number)
        {
            string convertedNumber = "";
            switch (number % 10)
            {
                case 0:
                    convertedNumber = "zero";
                    break;
                case 1:
                    convertedNumber = "one";
                    break;
                case 2:
                    convertedNumber = "two";
                    break;
                case 3:
                    convertedNumber = "three";
                    break;
                case 4:
                    convertedNumber = "four";
                    break;
                case 5:
                    convertedNumber = "five";
                    break;
                case 6:
                    convertedNumber = "six";
                    break;
                case 7:
                    convertedNumber = "seven";
                    break;
                case 8:
                    convertedNumber = "eight";
                    break;
                case 9:
                    convertedNumber = "nine";
                    break;
                default:
                    break;
            }

            Console.WriteLine("{0}", convertedNumber);
        }
    }
}
