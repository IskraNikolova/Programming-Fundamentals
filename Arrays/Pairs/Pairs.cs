using System;
using System.Linq;

namespace Pairs
{
    public class Pairs
    {
        public static void Main()
        {
            int[] inputIntegers = Console.ReadLine()
                .Trim()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int difference = int.Parse(Console.ReadLine().Trim());
            int count = 0;
            for (int i = 0; i < inputIntegers.Length; i++)
            {
                for (int j = 0; j < inputIntegers.Length; j++)
                {
                    int position = (j + i + 1)%inputIntegers.Length;
                    if (inputIntegers[i] - inputIntegers[position] == difference)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);   
        }
    }
}
