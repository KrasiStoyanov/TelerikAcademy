namespace TriangleSurfaceByTwoSidesAndAnAngle
{
    using System;

    public class Program
    {
        private static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double angle = DegreeToRadian(double.Parse(Console.ReadLine()));
            double surfaceOfTriangle = (a * b) / 2 * Math.Sin(angle);
            Console.WriteLine("{0:F2}", surfaceOfTriangle);
        }

        private static double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}
