namespace Interval
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int index = a + 1; index < b; index++)
            {
                if (index % 5 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine("{0}", counter);
        }
    }
}
