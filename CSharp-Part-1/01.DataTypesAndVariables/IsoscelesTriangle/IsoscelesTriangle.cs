namespace IsoscelesTriangle
{
    using System;
    using System.Text;

    public class IsoscelesTriangle
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            const char TRIANGLE_SYMBOL = '©';
            Console.WriteLine("   " + TRIANGLE_SYMBOL + "   ");
            Console.WriteLine("  " + TRIANGLE_SYMBOL + " " + TRIANGLE_SYMBOL + "  ");
            Console.WriteLine(" " + TRIANGLE_SYMBOL + " " + TRIANGLE_SYMBOL + " " + TRIANGLE_SYMBOL + " ");
            Console.WriteLine(TRIANGLE_SYMBOL + " " + TRIANGLE_SYMBOL + " " + TRIANGLE_SYMBOL + " " + TRIANGLE_SYMBOL);
        }
    }
}
