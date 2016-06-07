using System;
using System.Linq;

namespace HourglassSum
{
    public class HourglassSum
    {
        public static void Main()
        {
            int size = 6;
            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] line =
                    Console.ReadLine()
                        .Trim()
                        .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                   
                for (int column = 0; column < size; column++)
                {
                    matrix[row, column] = line[column];
                }
            }

            int bestSum = Int32.MinValue;
            for (int r = 0; r < size - 2; r++)
            {
                for (int c = 0; c < size - 2; c++)
                {
                    int sum = matrix[r, c] + matrix[r, c + 1] + matrix[r, c + 2] +
                              matrix[r + 1, c + 1] +
                              matrix[r + 2, c] + matrix[r + 2, c + 1] + matrix[r + 2, c + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }

            Console.WriteLine(bestSum);
        }
    }
}
