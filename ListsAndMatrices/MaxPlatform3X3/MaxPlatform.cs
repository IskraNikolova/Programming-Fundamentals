using System;
using System.Linq;

namespace MaxPlatform3X3
{
    public class MaxPlatform
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

            decimal[,] matrix = new decimal[rows, columns];
            for (int row = 0; row < rows; row++)
            {
                decimal[] line =
                    Console.ReadLine()
                        .Trim()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(decimal.Parse)
                        .ToArray();

                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = line[column];
                }
            }

            decimal bestSum = Decimal.MinValue;
            int bestRow = 0;
            int bestColumn = 0;
            for (int r = 0; r < rows - 2; r++)
            {
                for (int c = 0; c < columns - 2; c++)
                {
                    decimal sum = matrix[r, c] + matrix[r, c + 1] + matrix[r, c + 2] +
                           matrix[r + 1, c] + matrix[r + 1, c + 1] + matrix[r + 1, c + 2] +
                           matrix[r + 2, c] + matrix[r + 2, c + 1] + matrix[r + 2, c + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = r;
                        bestColumn = c;
                    }
                }
            }

            Console.WriteLine(bestSum);
            for (int i = bestRow; i < bestRow + 3; i++)
            {
                for (int j = bestColumn; j < bestColumn + 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
