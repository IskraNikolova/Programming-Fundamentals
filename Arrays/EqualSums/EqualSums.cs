using System;
using System.Linq;

namespace EqualSums
{
    public class EqualSums
    {
        public static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Trim()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < inputArray.Length; i++)
            {
                int diff = inputArray.Length - i;
                var leftSum = inputArray.Take(i).Sum();
                var rifgtSum = inputArray.Skip(i + 1).Take(diff).Sum();

                if (leftSum == rifgtSum)
                {
                    Console.WriteLine(i);
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("no");
        }
    }
}
