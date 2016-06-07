using System;
using System.Linq;

namespace TripleSum
{
    public class TripleSum
    {
        public static void Main()
        {
            long[] input = Console.ReadLine()
                .Trim()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            bool isNo = true;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    long sum = input[i] + input[j];
                    if (input.Contains(sum))
                    {
                        Console.WriteLine($"{input[i]} + {input[j]} == {sum}");
                        isNo = false;
                    }
                }
            }

            if (isNo)
            {
                Console.WriteLine("No");
            }
        }
    }
}
