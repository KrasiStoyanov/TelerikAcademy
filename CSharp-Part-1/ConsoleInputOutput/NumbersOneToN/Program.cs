namespace NumbersOneToN
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int index = 1; index <= n; index++)
            {
                Console.WriteLine("{0}", index);
            }
        }
    }
}
