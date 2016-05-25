namespace TriangleSurfaceBySideAndAltitude
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double surfaceOfTriangle = 0.5 * triangleSide * triangleHeight;
            Console.WriteLine("{0:F2}", surfaceOfTriangle);
        }
    }
}
