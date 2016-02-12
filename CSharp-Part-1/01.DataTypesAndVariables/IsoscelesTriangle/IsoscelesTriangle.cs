namespace IsoscelesTriangle
{
    using System;

    public class IsoscelesTriangle
    {
        public static void Main()
        {
            const char TRIANGLE_SYMBOL = '©';
            Console.WriteLine("   " + TRIANGLE_SYMBOL + "   ");
            Console.WriteLine("  " + TRIANGLE_SYMBOL + " " + TRIANGLE_SYMBOL + "  ");
            Console.WriteLine(" " + TRIANGLE_SYMBOL + " " + TRIANGLE_SYMBOL + " " + TRIANGLE_SYMBOL + " ");
            Console.WriteLine(TRIANGLE_SYMBOL + " " + TRIANGLE_SYMBOL + " " + TRIANGLE_SYMBOL + " " + TRIANGLE_SYMBOL);
        }
    }
}
