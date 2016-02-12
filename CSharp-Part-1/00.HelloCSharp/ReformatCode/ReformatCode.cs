namespace ReformatCode
{
    using System;

    public class ReformatCode
    {
        public static void Main()
        {
            Console.WriteLine("Hi, I am horribly formatted program");
            Console.WriteLine("Numbers and squares:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + " --> " + i * i);
            }
        }
    }
}