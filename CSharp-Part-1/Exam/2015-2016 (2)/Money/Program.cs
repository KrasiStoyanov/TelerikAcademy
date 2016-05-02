namespace Money
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double totalSheetsOfPaper = n * s;
            double realms = totalSheetsOfPaper / 400.000;
            double ammountOfMoney = realms * p;
            Console.WriteLine("{0:F3}", ammountOfMoney);
        }
    }
}
