using System;

namespace MatrixGenerator
{
    public class MatrixGenerator
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Trim()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string type = input[0];
            int row = int.Parse(input[1]);
            int column = int.Parse(input[2]);
            int[,] matrix = new int[row, column];
            switch (type)
            {
                case "A":
                    GenerateMatriciesTopDown(matrix);
                    break;
                case "B":
                    GenerateMatrixSnake(matrix);
                    break;
                case "C":
                    GenerateMatrixOfTypeC(matrix);
                    break;
                case "D":
                    GenerateSpirallMatrix(matrix);
                    break;
            }

            PrintMatrix(matrix);
        }

        private static void GenerateSpirallMatrix(int[,] matrix)
        {
            int row = 0;
            int col = 0;
            int value = 1;
            while (value < matrix.GetLength(0) * matrix.GetLength(1))
            {
                while (row < matrix.GetLength(0) && matrix[row, col] == 0)
                {
                    matrix[row, col] = value++;
                    row++;
                }

                row--;
                col++;

                while (col < matrix.GetLength(1) && matrix[row, col] == 0)
                {
                    matrix[row, col] = value++;
                    col++;
                }

                row--;
                col--;

                while (row >= 0 && matrix[row, col] == 0)
                {
                    matrix[row, col] = value++;
                    row--;
                }

                row++;
                col--;

                while (col >= 0 && matrix[row, col] == 0)
                {
                    matrix[row, col] = value++;
                    col--;
                }

                row++;
                col++;
            }           
        }
    
        private static void GenerateMatrixOfTypeC(int[,] matrix)
        {
            int value = 1;
            for (int startRow = matrix.GetLength(0) - 1; startRow >= 0; startRow--)
            {
                for (int row = startRow, column = 0; row < matrix.GetLength(0); row++, column++)
                {
                    matrix[row, column] = value++;
                }
            }

            int length = matrix.GetLength(0) - 1;
            for (int column = 1; column < matrix.GetLength(1); column++)
            {
                for (int count = length, row = 0, col = column; count >= 0; row++, col++, count--)
                {
                    matrix[row, col] = value++;
                }

                length--;
            }
        }

        private static void GenerateMatrixSnake(int[,] matrix)
        {
            int value = 1;
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                if (column%2 == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, column] = value++;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        matrix[row, column] = value++;
                    }
                }
            }
        }

        private static void GenerateMatriciesTopDown(int[,] matrix)
        {
            int value = 1;
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {                  
                    matrix[row, column] = value++;
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
