namespace Busses
{
    using System;

    public class Busses
    {
        public static void Main()
        {
            int numberOfBusses = int.Parse(Console.ReadLine());
            int[] speedsOfBusses = new int[numberOfBusses];
            int counter = 0;
            for (int index = 0; index < numberOfBusses; index++)
            {
                int speedOfBus = int.Parse(Console.ReadLine());
                speedsOfBusses[index] = speedOfBus;
            }

            for (int index = 0; index < numberOfBusses; index++)
            {
                if (index + 1 < numberOfBusses)
                {
                    if (speedsOfBusses[index] < speedsOfBusses[index + 1])
                    {
                        speedsOfBusses[index + 1] = speedsOfBusses[index];
                    }
                    else if (speedsOfBusses[index] > speedsOfBusses[index + 1])
                    {
                        counter++;
                    }
                    else if (speedsOfBusses[index] == speedsOfBusses[index + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        counter++;
                    }
                }
                else
                {
                    counter++;
                }
            }

            if (counter == 0)
            {
                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
