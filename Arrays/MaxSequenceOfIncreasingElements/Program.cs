using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfIncreasingElements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> largestSequence = new List<int>();

            int largestCountOfSequences = 0;
            string result = string.Empty;
            for (int index = 0; index < inputNumbers.Length - 1; index++)
            {
                if (inputNumbers[index] < inputNumbers[index + 1])
                {
                    largestSequence.Add(inputNumbers[index]);
                    if (index == inputNumbers.Length - 2)
                    {
                        largestSequence.Add(inputNumbers[index + 1]);

                        if (largestCountOfSequences < largestSequence.Count)
                        {
                            largestCountOfSequences = largestSequence.Count;

                            result = string.Join(" ", largestSequence);
                        }
                    }
                }
                else
                {
                    largestSequence.Add(inputNumbers[index]);

                    if (largestCountOfSequences < largestSequence.Count)
                    {
                        largestCountOfSequences = largestSequence.Count;

                        result = string.Join(" ", largestSequence);
                    }

                    largestSequence.Clear();

                    if (index == inputNumbers.Length - 2)
                    {
                        largestSequence.Add(inputNumbers[index + 1]);

                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
