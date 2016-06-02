namespace SafeFlights
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        private static List<int[]> allFlights = new List<int[]>();

        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            while (true)
            {
                int[] currentFlight = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                if (currentFlight[0] == -1 && currentFlight[1] == -1)
                {
                    break;
                }

                allFlights.Add(currentFlight);
            }

            FindAllSafeFlights(n);
        }

        private static void FindAllSafeFlights(int numberOfIslands)
        {
            var counter = allFlights.Count;
            var isTrue = false;
            for (int i = 0; i < allFlights.Count; i++)
            {
                var currentFlight = allFlights[i];
                var currentFlightA = currentFlight[0];
                var currentFlightB = currentFlight[1];

                int[] flight;
                var flightA = 0;
                var flightB = 0;
                int[] flightToSearch = new int[2];
                for (int j = i + 1; j < allFlights.Count; j++)
                {
                    flight = allFlights[j];
                    flightA = flight[0];
                    flightB = flight[1];
                    if (currentFlightA == -2 || flightA == -2)
                    {
                        continue;
                    }

                    if (currentFlightA == flightA && currentFlightB == flightB || 
                        currentFlightA == flightB && currentFlightB == flightA)
                    {
                        counter--;
                        isTrue = true;
                        flightToSearch = flight;
                        allFlights[j][0] = -2;
                        allFlights[j][1] = -2;
                    }
                }

                if (isTrue)
                {
                    counter--;
                    isTrue = false;
                    var index = allFlights.IndexOf(flightToSearch);
                    allFlights.RemoveAt(index);
                }
            }

            Console.WriteLine(counter);
        }
    }
}
