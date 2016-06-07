using System;
using System.Linq;

namespace ReverseAnArrayOfStrings
{
    public class ReverseAnArrayOfStrings
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();

            var reversed = input.Reverse().ToArray();

            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}
