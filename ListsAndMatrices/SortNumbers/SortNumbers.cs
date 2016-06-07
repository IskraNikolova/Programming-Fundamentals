using System;
using System.Collections.Generic;
using System.Linq;

namespace SortNumbers
{
    public class SortNumbers
    {
        public static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
            input.Sort();
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
