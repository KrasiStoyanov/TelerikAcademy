namespace TriangleSurfaceByThreeSides
{
    using System;

    public class Program
    {
        private static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double semiPerimeter = (a + b + c) / 2;
            double surfaceOfTriangle = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
            Console.WriteLine("{0:F2}", surfaceOfTriangle);
        }
    }
}
