using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace RoundingNumbers
{
    public class RoundingNumbers
    {
        public static void Main()
        {
            decimal[] input = Console.ReadLine()
                .Trim()
                .Split()
                .Select(decimal.Parse)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
      
                Console.WriteLine(Math.Round(input[i], 0, MidpointRounding.AwayFromZero));
            }
        }
    }
}
