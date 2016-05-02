namespace EncodingSum
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            long result = 0;
            while (true)
            {
                int charCode = Console.Read();
                char currentChar = (char)charCode;
                if (currentChar == '@')
                {
                    break;
                }

                if (Char.IsDigit(currentChar))
                {
                    result *= (currentChar - '0');
                }
                else if (Char.IsLetter(currentChar))
                {
                    result += Char.ToUpper(currentChar) - 65;
                }
                else
                {
                    result = result % m;
                }
            }

            Console.WriteLine(result);
        }
    }
}
