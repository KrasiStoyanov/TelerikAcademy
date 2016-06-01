namespace FillTheMatrix
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char character = char.Parse(Console.ReadLine());

            if (character == 'a')
            {
                FillTheMatrixVariantA(n);
            }
            else if (character == 'b')
            {
                FillTheMatrixVariantB(n);
            }
            else if (character == 'c')
            {
                FillTheMatrixVariantC(n);
            }
            else if (character == 'd')
            {
                FillTheMatrixVariantD(n);
            }
        }

        public static void FillTheMatrixVariantA(int n)
        {
            int counter = 1;
            int[,] resultMatrix = new int[n, n];
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    resultMatrix[row, col] = counter;
                    counter++;
                }
            }

            PrintMatrix(resultMatrix);
        }

        public static void FillTheMatrixVariantB(int n)
        {
            int counter = 1;
            int[,] resultMatrix = new int[n, n];
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        resultMatrix[row, col] = counter;
                        counter++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        resultMatrix[row, col] = counter;
                        counter++;
                    }
                }
            }

            PrintMatrix(resultMatrix);
        }

        public static void FillTheMatrixVariantC(int n)
        {
            int counter = 1;
            int[,] resultMatrix = new int[n, n];

            int col = 0;
            int row = 0;
            int currentRow = 0;
            int currentCol = 0;
            for (row = n - 1; row >= 0; row--)
            {
                currentRow = row;
                currentCol = col;
                while (currentCol < n && currentRow < n)
                {
                    resultMatrix[currentRow, currentCol] = counter;
                    counter++;
                    currentRow++;
                    currentCol++;
                }
            }

            row = 0;
            currentCol = 0;
            currentRow = 0;
            for (col = 1; col < n; col++)
            {
                currentRow = row;
                currentCol = col;
                while (currentCol < n && currentRow < n)
                {
                    resultMatrix[currentRow, currentCol] = counter;
                    counter++;
                    currentRow++;
                    currentCol++;
                }
            }

            PrintMatrix(resultMatrix);
        }

        public static void FillTheMatrixVariantD(int n)
        {
            // TODO: Implement logic for making the spiral matrix
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col > 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("{0}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
