namespace QuotesInString
{
    using System;

    public class QuotesInString
    {
        public static void Main()
        {
            string firstString = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(firstString);
            Console.WriteLine();

            string secondString = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(secondString);
            Console.WriteLine();
        }
    }
}
