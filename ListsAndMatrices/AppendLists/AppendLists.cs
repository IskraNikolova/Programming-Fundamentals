namespace AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                .Trim()
                .Split(new[] {'|'})
                .ToList();

            List<int> result = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
               result.AddRange(input[i]
                   .Trim()
                   .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .Reverse());
            }

            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
