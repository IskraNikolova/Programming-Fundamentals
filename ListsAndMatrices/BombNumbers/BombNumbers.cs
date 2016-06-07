using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    public class BombNumbers
    {
        public static void Main()
        {
            List<int> input =
                Console.ReadLine()
                    .Trim()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            int[] commands = Console.ReadLine()
                    .Trim()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int element = commands[0];
            int bomb = commands[1];

            while (input.Contains(element))
            {
                int index = input.IndexOf(element);
                int firstIndex = Math.Max(0, index - bomb);
                int lastIndex = Math.Min(input.Count, index + bomb);
                int count = lastIndex - firstIndex;
                input.RemoveRange(firstIndex, count + 1);
            }

            Console.WriteLine(input.Sum());
        }
    }
}
