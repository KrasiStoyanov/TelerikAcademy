namespace SumOfThreeNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double userFirstNumber = double.Parse(Console.ReadLine());
            double userSecondNumber = double.Parse(Console.ReadLine());
            double userThirdNumber = double.Parse(Console.ReadLine());
            double sumOfUserNumbers = userFirstNumber + userSecondNumber + userThirdNumber;
            Console.WriteLine("{0}", sumOfUserNumbers);
        }
    }
}
