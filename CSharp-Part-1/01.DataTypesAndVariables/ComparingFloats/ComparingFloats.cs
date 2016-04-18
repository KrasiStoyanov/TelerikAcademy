namespace ComparingFloats
{
    using System;

    public class ComparingFloats
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            bool areEqual = Math.Abs(a - b) < 0.000001;

            if (areEqual)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
