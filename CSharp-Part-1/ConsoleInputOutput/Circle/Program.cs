namespace Circle
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;
            Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
        }
    }
}
