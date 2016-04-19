namespace Cube
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}", new String(' ', n - 1), new String(':', n));
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{5}", new String(' ', n - (i + 2)), ':', new String('/', n - 2), ':', new String('X', i), ':');
            }
            Console.WriteLine("{0}{1}{2}", new String(':', n), new String('X', n - 2), ':');
            for (int i = n - 3; i >= 0; i--)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", ':', new String(' ', n - 2), ':', new String('X', i), ':');
            }
            Console.WriteLine("{0}", new String(':', n));
        }
    }
}
