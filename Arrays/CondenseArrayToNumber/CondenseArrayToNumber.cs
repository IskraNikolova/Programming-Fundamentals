using System;
using System.Collections.Generic;
using System.Linq;

namespace CondenseArrayToNumber
{
    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            List<long> input = Console.ReadLine()
                .Trim()
                .Split()
                .Select(long.Parse)
                .ToList();

            List<long> working = new List<long>();
            while (input.Count > 2)
            {    
                working.Clear();
                for (int i = 0; i < input.Count - 1; i++)
                {          
                    working.Add(input[i] + input[i + 1]);
                }
              
                input.Clear();
                foreach (var el in working)
                {
                    input.Add(el);
                }
            }

            Console.WriteLine(input.Sum());
        }
    }
}
