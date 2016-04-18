namespace ThirdDigitIsSeven
{
    using System;

    public class ThirdDigitIsSeven
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            byte numberOfDigitToPresent = 3;
            while (numberOfDigitToPresent - 1 == 0)
            {
                a /= 10;
            }
            a = a % 10 + '0';

            Console.WriteLine("Third digit of {0} is: {0}", a);
        }
    }
}
