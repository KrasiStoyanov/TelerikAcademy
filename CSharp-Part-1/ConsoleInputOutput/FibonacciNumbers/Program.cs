namespace FibonacciNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            long length = long.Parse(Console.ReadLine());

            long current;
            long previous = 1;
            long beforePrevious = 0;

            for (int index = 0; index < length; index++)
            {
                if (index == 0)
                {
                    current = beforePrevious;
                }
                else if (index == 1)
                {
                    current = previous;
                }
                else
                {
                    current = beforePrevious + previous;
                    beforePrevious = previous;
                    previous = current;
                }


                if (index < length - 1)
                {
                    Console.Write("{0}, ", current);
                }
                else
                {
                    Console.Write(current);
                }
            }
        }
    }
}
