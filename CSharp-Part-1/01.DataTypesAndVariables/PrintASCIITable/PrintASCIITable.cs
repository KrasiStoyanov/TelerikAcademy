namespace PrintASCIITable
{
    using System;
    using System.Text;

    public class PrintASCIITable
    {
        public static void Main()
        {
            for (int i = 33; i <= 126; i++)
            {
                Console.Write("{0}", (char)i);
            }
        }
    }
}
