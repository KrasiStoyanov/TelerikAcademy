namespace NullValuesArithmetic
{
    using System;

    public class NullValuesArithmetic
    {
        public static void Main()
        {
            int? a = null;
            double? b = null;

            Console.WriteLine("a[null] = {0}", a);
            Console.WriteLine("b[null] = {0}", b);

            Console.WriteLine("a[null + number] = {0}", (a + 3));
            Console.WriteLine("b[null + null] = {0}", (b + null));
        }
    }
}
