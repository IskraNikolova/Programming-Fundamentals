using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareNumbers2
{
    public class SquareNumbers2
    {
        public static void Main()
        {
            List<int> input =
                Console.ReadLine()
                    .Trim()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            List<int> square = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (Math.Sqrt(input[i]) == (int) Math.Sqrt(input[i]))
                {
                    square.Add(input[i]);
                }
            }

            square.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", square));
        }
    }
}
