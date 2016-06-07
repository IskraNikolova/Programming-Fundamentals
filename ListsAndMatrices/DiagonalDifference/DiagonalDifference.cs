using System;
using System.Linq;

namespace DiagonalDifference
{
    public class DiagonalDifference
    {
        public static void Main()
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine().Trim());

            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
            for (int row = 0; row < sizeOfMatrix; row++)
            {
                int[] columnValues =
                    Console.ReadLine()
                        .Trim()
                        .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                for (int column = 0; column < sizeOfMatrix; column++)
                {
                    matrix[row, column] = columnValues[column];
                }
            }

            int firstDiagonalsSum = 0;
            int secondDiagonalSum = 0;
            for (int i = 0; i < sizeOfMatrix; i++)
            {
                firstDiagonalsSum += matrix[i, i];
                secondDiagonalSum += matrix[i, sizeOfMatrix - 1 - i];
            }

            Console.WriteLine(Math.Abs(firstDiagonalsSum - secondDiagonalSum));
        }
    }
}
