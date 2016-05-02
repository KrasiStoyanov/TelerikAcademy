namespace Feathers
{
    using System;

    public class Feathers
    {
        public static void Main()
        {
            double numberOfBirds = int.Parse(Console.ReadLine());
            double numberOfFeathers = long.Parse(Console.ReadLine());
            double average = numberOfFeathers / numberOfBirds;
            if (numberOfBirds == 0 || numberOfFeathers == 0)
            {
                average = 0;
            }
            double result = 0;
            if (numberOfBirds % 2 == 0)
            {
                result = average * 123123123123;
            }
            else
            {
                result = average / 317;
            }

            Console.WriteLine("{0:F4}", result);
        }
    }
}
