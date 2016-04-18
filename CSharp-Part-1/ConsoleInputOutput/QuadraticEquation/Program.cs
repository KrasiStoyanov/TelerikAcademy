namespace QuadraticEquation
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            double firstRoot = 0;
            double secondRoot = 0;
            double onlyRoot = 0;
            string negativeRoot = "";
            if (d > 0)
            {
                firstRoot = (-b + Math.Sqrt(d)) / (2 * a);
                secondRoot = (-b - Math.Sqrt(d)) / (2 * a);
                if (firstRoot > secondRoot)
                {
                    Console.WriteLine("{0:F2}\n{1:F2}", secondRoot, firstRoot);
                }
                else
                {
                    Console.WriteLine("{0:F2}\n{1:F2}", firstRoot, secondRoot);
                }
            }
            else if (d == 0)
            {
                onlyRoot = -(b / (2 * a));
                Console.WriteLine("{0:F2}", onlyRoot);
            }
            else
            {
                negativeRoot = "no real roots";
                Console.WriteLine(negativeRoot);
            }
        }
    }
}
