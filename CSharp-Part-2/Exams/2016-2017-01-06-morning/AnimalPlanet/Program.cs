namespace AnimalPlanet
{
    using System;
    using System.Linq;

    public class Program
    {
        private static int[] porcupinePos = new int[2];
        private static int[] rabbitPos = new int[2];
        private static int porcupinePoints = 0;
        private static int rabbitPoints = 0;

        private static void Main()
        {
            // Receive data for creating the jagged array (forest)
            int cols = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];
            fillJaggedArray(jaggedArray, rows, cols);

            // Receive initial position of animals
            porcupinePos = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            rabbitPos = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            Play(jaggedArray, rows, cols);
        }

        private static void Play(int[][] jaggedArray, int rows, int cols)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] sequence = input.Split(' ');
                char whichAnimal = char.Parse(sequence[0]);
                char facingDirection = char.Parse(sequence[1]);
                int numberOfCells = int.Parse(sequence[2]);

                if (whichAnimal == 'R')
                {
                    MoveRabbit(facingDirection, numberOfCells, jaggedArray);
                }
                else if (whichAnimal == 'P')
                {
                    MovePorcupine(facingDirection, numberOfCells, jaggedArray);
                }
            }

            if (porcupinePoints > rabbitPoints)
            {
                Console.WriteLine("The porcupine destroyed the rabbit with {0} points.The rabbit must work harder.He scored {1} points only.", porcupinePoints, rabbitPoints);
            }
            else if (porcupinePoints == rabbitPoints)
            {
                Console.WriteLine("Both units scored {0} points. Maybe we should play again?", porcupinePoints);
            }
            else
            {
                Console.WriteLine("The rabbit WON with {0} points. The porcupine scored {1} points only.", rabbitPoints, porcupinePoints);
            }
        }

        private static void MoveRabbit(char facingDirection, int numberOfCells, int[][] jaggedArray)
        {
            var row = rabbitPos[0];
            var col = rabbitPos[1];

            rabbitPoints += jaggedArray[row][col];
            jaggedArray[row][col] = 0;
            var currentArr = jaggedArray[row];
            var steps = row;
            switch (facingDirection)
            {
                case 'T':
                    row = (row - numberOfCells) % jaggedArray.Length;
                    if (row < 0)
                    {
                        row = row + jaggedArray.Length;
                    }
                    else if (row == porcupinePos[0] && col == porcupinePos[1])
                    {
                        row++;
                    }

                    break;
                case 'R':
                    col = (col + numberOfCells) % currentArr.Length;
                    if (col >= currentArr.Length)
                    {
                        col -= currentArr.Length;
                    }
                    else if (col == porcupinePos[1] && row == porcupinePos[0])
                    {
                        col--;
                    }

                    break;
                case 'B':
                    row = (row + numberOfCells) % jaggedArray.Length;
                    if (row == 0 && row < steps)
                    {
                        row = steps;
                    }

                    if (row >= jaggedArray.Length)
                    {
                        row = row - jaggedArray.Length;
                    }
                    else if (row == porcupinePos[0] && col == porcupinePos[1])
                    {
                        row--;
                    }

                    break;
                case 'L':
                    col = (col - numberOfCells) % currentArr.Length;
                    if (col < 0)
                    {
                        col += currentArr.Length;
                    }
                    else if (col == porcupinePos[1] && row == porcupinePos[0])
                    {
                        col++;
                    }
                    break;
            }

            rabbitPoints += jaggedArray[row][col];
            jaggedArray[row][col] = 0;
            if (row < 0)
            {
                row += jaggedArray.Length;
            }

            if (col < 0)
            {
                col += jaggedArray[row].Length;
            }

            rabbitPos[0] = row;
            rabbitPos[1] = col;
        }

        private static void MovePorcupine(char facingDirection, int numberOfCells, int[][] jaggedArray)
        {
            var row = porcupinePos[0];
            var col = porcupinePos[1];
            while (numberOfCells > 0)
            {
                porcupinePoints += jaggedArray[row][col];
                jaggedArray[row][col] = 0;
                var currentArr = jaggedArray[row];
                switch (facingDirection)
                {
                    case 'T':
                        if (row - 1 < 0)
                        {
                            row = jaggedArray.Length - 1;
                        }
                        else if (jaggedArray[row - 1].Length - 1 < col)
                        {
                            row = jaggedArray.Length - row - 1;
                        }
                        else if (row - 1 == rabbitPos[0] && col == rabbitPos[1])
                        {
                            break;
                        }
                        else
                        {
                            row--;
                        }

                        break;
                    case 'R':
                        if (col + 1 >= currentArr.Length)
                        {
                            col = currentArr.Length - 1;
                        }
                        else if (col + 1 == rabbitPos[1] && row == rabbitPos[0])
                        {
                            break;
                        }
                        else
                        {
                            col++;
                        }

                        break;
                    case 'B':
                        if (jaggedArray[row + 1].Length - 1 < col)
                        {
                            row = jaggedArray.Length - row - 1;
                        }
                        else if (row + 1 >= jaggedArray.Length)
                        {
                            row = jaggedArray.Length - 1;
                        }
                        else if (row + 1 == rabbitPos[0] && col == rabbitPos[1])
                        {
                            break;
                        }
                        else
                        {
                            row++;
                        }

                        break;
                    case 'L':
                        if (col - 1 < 0)
                        {
                            col = currentArr.Length - 1;
                        }
                        else if (col - 1 == rabbitPos[1] && row == rabbitPos[0])
                        {
                            break;
                        }
                        else
                        {
                            col--;
                        }

                        break;
                }

                numberOfCells--;
            }

            porcupinePoints += jaggedArray[row][col];
            jaggedArray[row][col] = 0;
            if (row < 0)
            {
                row += jaggedArray.Length;
            }

            if (col < 0)
            {
                col += jaggedArray[row].Length;
            }

            porcupinePos[0] = row;
            porcupinePos[1] = col;
        }

        private static void fillJaggedArray(int[][] jaggedArray, int rows, int cols)
        {
            var counter = 0;
            int row = 0;
            int steps = cols;
            for (row = 0; row < jaggedArray.Length / 2; row++)
            {
                jaggedArray[row] = new int[cols];
                counter = row + 1;
                for (int col = 0; col < cols; col++)
                {
                    jaggedArray[row][col] = counter;
                    counter += row + 1;
                }

                cols += steps;
            }

            if (rows % 2 == 0)
            {
                cols -= steps;
            }

            for (; row < jaggedArray.Length; row++)
            {
                jaggedArray[row] = new int[cols];
                counter = row + 1;
                for (int col = 0; col < cols; col++)
                {
                    jaggedArray[row][col] = counter;
                    counter += row + 1;
                }

                cols -= steps;
            }
        }
    }
}
