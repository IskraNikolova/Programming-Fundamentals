using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    public class MaxSequenceOfEqualElements
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

            var ordered = result.OrderByDescending(p => p.Value).First();
            for (int i = 0; i < ordered.Value; i++)
            {
                Console.Write(ordered.Key + " ");
            }
        }
    }
}
