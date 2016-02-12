namespace ExchangeVariableValues
{
    using System;

    public class ExchangeVariableValues
    {
        public static void Main()
        {
            int a = 5;
            int b = 10;

            // EXCHANGE VALUES
            int helper = a;
            a = b;
            b = helper;

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
        }
    }
}
