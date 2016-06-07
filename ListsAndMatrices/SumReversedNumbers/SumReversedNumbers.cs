using System;
using System.Linq;

namespace SumReversedNumbers
{
    public class SumReversedNumbers
    {
        public static void Main()
        {
            string[] input =
                Console.ReadLine()
                    .Trim()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char[] arr = input[i].ToCharArray();
                Array.Reverse(arr);
                string reverse = string.Join("", arr);
                int added = int.Parse(reverse);
                sum += added;
            }

            Console.WriteLine(sum);
        }
    }
}
