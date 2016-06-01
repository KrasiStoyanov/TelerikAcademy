namespace SayHello
{
    using System;

    public class Program
    {
        public static void Main()
        {
            PrintUserName();
        }

        private static void PrintUserName()
        {
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", userName);
        }
    }
}
