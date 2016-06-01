namespace LoverOf3
{
    using System;

    public class Program
    {
        private static int pawnRow = 0;
        private static int pawnCol = 0;

        private static void Main()
        {
            string[] dimensions = Console.ReadLine().Split(' ');
            int row = int.Parse(dimensions[0]);
            int col = int.Parse(dimensions[1]);
            int[,] matrix = new int[row, col];
            bool[,] boolMatrix = new bool[row, col];
            FillMatrix(matrix);

            int numberOfDirections = int.Parse(Console.ReadLine());
            int result = ReceiveDirectionsAndCalculateSum(numberOfDirections, matrix, boolMatrix);
            Console.WriteLine(result);
        }

        private static void FillMatrix(int[,] matrix)
        {
            int startingCounter = 0;
            int counter = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                counter = startingCounter;
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = counter;
                    counter += 3;
                }

                startingCounter += 3;
            }
        }

        private static int ReceiveDirectionsAndCalculateSum(int numberOfDirections, int[,] matrix, bool[,] boolMatrix)
        {
            int sum = 0;
            pawnRow = matrix.GetLength(0) - 1;
            for (int i = 0; i < numberOfDirections; i++)
            {
                string[] currentDirections = Console.ReadLine().Split(' ');
                string directionString = currentDirections[0];
                int currentPawnMoves = int.Parse(currentDirections[1]);
                int counter = 1;

                while (counter <= currentPawnMoves && 
                    pawnCol < matrix.GetLength(1) && pawnCol >= 0 &&
                    pawnRow < matrix.GetLength(0) && pawnRow >= 0)
                {
                    if (boolMatrix[pawnRow, pawnCol] == false)
                    {
                        sum += matrix[pawnRow, pawnCol];
                        boolMatrix[pawnRow, pawnCol] = true;
                    }

                    switch (directionString)
                    {
                        case "RU":
                        case "UR":
                            pawnRow--;
                            pawnCol++;
                            break;
                        case "LU":
                        case "UL":
                            pawnRow--;
                            pawnCol--;
                            break;
                        case "DR":
                        case "RD":
                            pawnRow++;
                            pawnCol++;
                            break;
                        case "DL":
                        case "LD":
                            pawnRow++;
                            pawnCol--;
                            break;
                        default:
                            break;
                    }

                    counter++;
                }

                switch (directionString)
                {
                    case "RU":
                    case "UR":
                        pawnRow++;
                        pawnCol--;
                        break;
                    case "LU":
                    case "UL":
                        pawnRow++;
                        pawnCol++;
                        break;
                    case "DR":
                    case "RD":
                        pawnRow--;
                        pawnCol--;
                        break;
                    case "DL":
                    case "LD":
                        pawnRow--;
                        pawnCol++;
                        break;
                    default:
                        break;
                }
            }

            return sum;
        }
    }
}
