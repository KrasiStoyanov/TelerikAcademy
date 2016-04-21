namespace SaddyKopper
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            long userNumber = long.Parse(Console.ReadLine());
            int sum = CalculateSumOfDigits(userNumber);
            if (sum.ToString().Length > 1)
            {
                sum = CalculateSumOfDigits(sum);
            }

            Console.WriteLine(sum);
        }

        public static int CalculateSumOfDigits(long inputNumber)
        {
            int sum = 1;
            int numberOfTransformations = 0;
            for (int index = 0; index < inputNumber.ToString().Length; index++)
            {
                bool odd = false;
                inputNumber = inputNumber / 10;
                int evenSum = inputNumber.ToString().Sum(c => (odd = !odd) ? c - '0' : 0);
                sum *= evenSum;
                numberOfTransformations += 1;

                if (numberOfTransformations == 10)
                {
                    break;
                }
            }

            return sum;
        }
    }
}
