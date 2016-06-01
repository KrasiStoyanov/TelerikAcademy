namespace TwoGirlsOnePath
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Program
    {
        private static void Main()
        {
            BigInteger[] cells = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            string winner = "";

            bool isOver = false;
            int mollyPosition = 0;
            int dollyPosition = cells.Length - 1;

            BigInteger mollyTotalFlowers = 0;
            BigInteger dollyTotalFlowers = 0;

            while (!isOver)
            {
                if (cells[mollyPosition] == 0 || cells[dollyPosition] == 0)
                {
                    if (cells[mollyPosition] == 0 && cells[dollyPosition] == 0)
                    {
                        winner = "Draw";
                    }
                    else if (cells[mollyPosition] == 0)
                    {
                        winner = "Dolly";
                    }

                    else
                    {
                        winner = "Molly";
                    }

                    mollyTotalFlowers += cells[mollyPosition];
                    dollyTotalFlowers += cells[dollyPosition];
                    break;
                }

                BigInteger currentMollyFlowers = cells[mollyPosition];
                BigInteger currentDollyFlowers = cells[dollyPosition];

                if (mollyPosition == dollyPosition)
                {
                    cells[mollyPosition] = currentMollyFlowers % 2;
                    mollyTotalFlowers += currentMollyFlowers / 2;
                    dollyTotalFlowers += currentDollyFlowers / 2;
                }

                else
                {
                    cells[mollyPosition] = 0;
                    cells[dollyPosition] = 0;

                    mollyTotalFlowers += currentMollyFlowers;
                    dollyTotalFlowers += currentDollyFlowers;
                }

                mollyPosition = (int)((mollyPosition + currentMollyFlowers) % cells.Length);
                dollyPosition = (int)((dollyPosition - currentDollyFlowers) % cells.Length);
                if (dollyPosition < 0)
                {
                    dollyPosition += cells.Length;
                }
            }

            Console.WriteLine("{0}" + "\n" + "{1} {2}", winner, mollyTotalFlowers, dollyTotalFlowers);
        }
    }
}
