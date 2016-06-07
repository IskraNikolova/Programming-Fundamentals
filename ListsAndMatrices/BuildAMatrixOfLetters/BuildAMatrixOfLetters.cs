using System;

namespace BuildAMatrixOfLetters
{
    public class BuildAMatrixOfLetters
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine().Trim());
            int columns = int.Parse(Console.ReadLine().Trim());

            char[,] matrix = new char[rows, columns];

            char firstSymbol = 'A';
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = firstSymbol++;
                    Console.Write(matrix[row, column] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
