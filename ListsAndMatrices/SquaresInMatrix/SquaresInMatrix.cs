using System;
using System.Linq;

namespace SquaresInMatrix
{
    public class SquaresInMatrix
    {
        public static void Main()
        {
            int[] rowsAndColumns =
                Console.ReadLine()
                    .Trim()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int rows = rowsAndColumns[0];
            int columns = rowsAndColumns[1];

            char[,] matrix = new char[rows, columns];
            for (int row = 0; row < rows; row++)
            {
                char[] line =
                    Console.ReadLine()
                        .Trim()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(char.Parse)
                        .ToArray();

                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int counter = 0;
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < columns - 1; j++)
                {
                    bool isEqual = matrix[i, j] == matrix[i, j + 1] &&
                             matrix[i, j] == matrix[i + 1, j] &&
                             matrix[i, j] == matrix[i + 1, j + 1];

                    if (isEqual)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
