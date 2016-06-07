using System;
using System.Linq;

namespace MatrixOfPalindromes
{
    public class MatrixOfPalindromes
    {
        public static void Main()
        {
            int[] rowsAndColumns =
                Console.ReadLine()
                    .Trim()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int rows = rowsAndColumns[0];
            int columns = rowsAndColumns[1];
  
            char firstRow = 'a';           

            for (int row = 0; row < rows; row++)
            {
                char firstColumn = (char)(97 + row);
                for (int column = 0; column < columns; column++)
                {
                    Console.Write($"{firstRow}{firstColumn}{firstRow}" + " ");
                    firstColumn++;
                }

                Console.WriteLine();
                firstRow++;
            }
        }
    }
}
