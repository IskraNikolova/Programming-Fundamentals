using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace FoldAndSum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Trim()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = inputArray.Length/4;

            var firstKElement = inputArray
                .Take(k).
                Reverse();

            var secondRow = inputArray
                .Skip(k)
                .Take(inputArray.Length - 2*k).ToArray();

            var secondKElement = inputArray
                .Skip(firstKElement.Count() + secondRow.Count())
                .Take(k)
                .Reverse();

            var firstRow = firstKElement.Concat(secondKElement).ToArray();

            for (int i = 0; i < firstRow.Length; i++)
            {
               Console.Write(firstRow[i] + secondRow[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
