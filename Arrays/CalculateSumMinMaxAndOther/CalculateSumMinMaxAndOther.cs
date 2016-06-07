using System;
using System.Linq;

namespace CalculateSumMinMaxAndOther
{
    public class CalculateSumMinMaxAndOther
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine().Trim());
            int[] input = new int[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine().Trim());
            }

            Console.WriteLine($"Sum = {input.Sum()}");
            Console.WriteLine($"Min = {input.Min()}");
            Console.WriteLine($"Max = {input.Max()}");
            Console.WriteLine($"First = {input.First()}");
            Console.WriteLine($"Last = {input.Last()}");
            Console.WriteLine($"Average = {input.Average()}");
        }
    }
}
