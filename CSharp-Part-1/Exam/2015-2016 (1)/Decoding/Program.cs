namespace Decoding
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int salt = int.Parse(Console.ReadLine());
            int position = 0;
            while (true)
            {
                int charCode = Console.Read();
                char currentChar = (char)charCode;

                if (currentChar == '@')
                {
                    break;
                }

                int newCode = 0;
                if (Char.IsLetter(currentChar))
                {
                    newCode = (charCode * salt) + 1000;
                }
                else if (Char.IsDigit(currentChar))
                {
                    newCode = charCode + salt + 500;
                }
                else
                {
                    newCode = charCode - salt;
                }

                if (position % 2 == 0)
                {
                    Console.WriteLine("{0:F2}", newCode / 100.0);
                }
                else
                {
                    Console.WriteLine("{0}", newCode * 100);
                }

                position++;
            }
        }
    }
}
