namespace DivideBySevenAndFive
{
    using System;

    public class DivideBySevenAndFive
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string canBeDivided = "";
            if (n % 5 == 0 && n % 7 == 0)
            {
                canBeDivided = "true";
            }
            else
            {
                canBeDivided = "false";
            }

            Console.WriteLine("{0} {1}", canBeDivided, n);
        }
    }
}
