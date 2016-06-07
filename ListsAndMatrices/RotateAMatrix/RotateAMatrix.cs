using System;
using System.ComponentModel;
using System.Linq;

namespace RotateAMatrix
{
    public class RotateAMatrix
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine().Trim());
            int columns = int.Parse(Console.ReadLine().Trim());

            string[,] matrix = new string[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                string inputLine = Console.ReadLine();
                if (inputLine != null)
                {
                    string[] line = inputLine
                        .Trim()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    for (int column = 0; column < columns; column++)
                    {
                        matrix[row, column] = line[column];
                    }
                }           
            }

            for (int column = 0; column < columns; column++)
            {
                for (int row = rows - 1; row >= 0; row--)
                {
                    Console.Write(matrix[row, column] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
