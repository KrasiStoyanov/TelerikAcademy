﻿namespace PrintASequence
{
    using System;

    public class PrintASequence
    {
        public static void Main()
        {
            const int START_NUMBER = 2;
            const int END_NUMBER = 11;
            for (int i = START_NUMBER; i <= END_NUMBER; i++)
            {
                if (i == END_NUMBER)
                {
                    Console.Write(-i);
                }
                else if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(-i + ", ");
                }
            }

            Console.WriteLine();
        }
    }
}
