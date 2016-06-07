using System;
using System.Linq;

namespace ExtractMiddleElements
{
    public class ExtractMiddleElements
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //if (input.Length == 1)
            //{
            //    Console.WriteLine($"{{ {input[0]} }}");
            //}
            if (input.Length%2 == 0)
            {
                var result = input.Skip((input.Length/2) - 1).Take(2).ToArray();
                Console.WriteLine($"{{ {string.Join(", ", result)} }}");
            }
            else
            {
                var result = input.Skip((input.Length / 2) - 1).Take(3).ToArray();
                Console.WriteLine($"{{ {string.Join(", ", result)} }}");
            }
        }
    }
}
