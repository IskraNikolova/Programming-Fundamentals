using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers
{
    public class CountNumbers
    {
        public static void Main()
        {
            List<int> input =
                Console.ReadLine()
                    .Trim()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (!result.ContainsKey(input[i]))
                {
                    result.Add(input[i], 0);
                }

                result[input[i]]++;
            }

            var ordered = result.OrderBy(p => p.Key);
            foreach (var pair in ordered)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
