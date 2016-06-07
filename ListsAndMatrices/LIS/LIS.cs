using System;
using System.Collections.Generic;
using System.Linq;

namespace LIS
{
    public class LongestIncreasingSubsequence
    {
        public static void Main()
        {
            var sequence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var longestSequence = FindLongestIncreasingSubsequence(sequence);

            Console.WriteLine(string.Join(", ", longestSequence));
        }

        public static int[] FindLongestIncreasingSubsequence(int[] sequence)
        {
            int length = sequence.Length;
            int[] newCollection = new int[length];
            int[] prevCollection = new int[length];

            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < length; i++)
            {
                newCollection[i] = 1;
                prevCollection[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (sequence[j] < sequence[i] && newCollection[j] >= newCollection[i])
                    {
                        newCollection[i] = 1 + newCollection[j];
                        prevCollection[i] = j;
                    }
                }

                if (newCollection[i] > maxLength)
                {
                    maxLength = newCollection[i];
                    lastIndex = i;
                }
            }

            var longestSeq = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                longestSeq.Add(sequence[lastIndex]);
                lastIndex = prevCollection[lastIndex];
            }

            longestSeq.Reverse();
            return longestSeq.ToArray();
        }
    }
}
