namespace ComparingFloats
{
    using System;

    public class ComparingFloats
    {
        public static void Main()
        {
            double a = -0.0000007;
            double b = -0.0000007;
            double difference = Math.Abs(a * 0.000001);

            if (Math.Abs(a - b) < difference)
            {
                Console.WriteLine("a ({0}) and b ({1}) are equal.", a, b);
            }
            else
            {
                Console.WriteLine("a ({0}) and b ({1}) are not equal.", a, b);
            }
        }
    }
}
