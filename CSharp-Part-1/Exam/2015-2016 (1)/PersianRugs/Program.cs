namespace PersianRugs
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int width = n * 2 + 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}", new String('#', i));
                Console.Write("\\");

                int spaceLeft = width - i - i - 2 - d - d;
                if (spaceLeft > 1)
                {
                    Console.Write(new String(' ', d));
                    Console.Write('\\');
                    Console.Write(new String('.', spaceLeft - 2));
                    Console.Write('/');
                    Console.Write(new String(' ', d));
                }
                else
                {
                    Console.Write("{0}", new string(' ', width - i - i - 2));
                }

                Console.Write("/");
                Console.Write("{0}", new String('#', i));

                Console.WriteLine();
            }

            Console.WriteLine("{0}{1}{2}", new String('#', n), 'X', new String('#', n));


            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write("{0}", new String('#', i));
                Console.Write("/");

                int spaceLeft = width - i - i - 2 - d - d;
                if (spaceLeft > 1)
                {
                    Console.Write(new String(' ', d));
                    Console.Write('/');
                    Console.Write(new String('.', spaceLeft - 2));
                    Console.Write('\\');
                    Console.Write(new String(' ', d));
                }
                else
                {
                    Console.Write("{0}", new string(' ', width - i - i - 2));
                }

                Console.Write("\\");
                Console.Write("{0}", new String('#', i));

                Console.WriteLine();
            }
        }
    }
}
