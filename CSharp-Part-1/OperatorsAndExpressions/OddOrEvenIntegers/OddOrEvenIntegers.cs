namespace OddOrEvenIntegers
{
    using System;

    public class OddOrEvenIntegers
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            string isOdd = "";

            if (a % 2  == 0)
            {
                isOdd = "even";
            }
            else
            {
                isOdd = "odd";
            }

            Console.WriteLine("{0} {1}", isOdd, a);
        }
    }
}
