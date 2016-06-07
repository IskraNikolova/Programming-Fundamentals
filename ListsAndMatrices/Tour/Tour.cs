using System;
using System.Collections.Generic;
using System.Linq;

namespace Tour
{
    public class Tour
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine().Trim());

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

            List<int> commands =
                Console.ReadLine()
                    .Trim()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            commands.Insert(0, 0);

            int distance = 0;
            for (int i = 0; i < commands.Count - 1; i++)
            {
                int row = commands[i];
                int column = commands[i + 1];
                distance += matrix[row, column];
            }

            Console.WriteLine(distance);
        }
    }
}
