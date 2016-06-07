using System;
using System.Collections.Generic;
using System.Linq;

namespace MostFrequentNumber
{
    public class Program
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            Dictionary<int, int> collection = new Dictionary<int, int>();
            for (int index = 0; index < input.Length; index++)
            {
                if (!collection.ContainsKey(input[index]))
                {
                    collection.Add(input[index], 0);
                }

                collection[input[index]]++;
            }

            var order = collection.OrderByDescending(p => p.Value).FirstOrDefault();
            Console.WriteLine(order.Key);
        }
    }
}
