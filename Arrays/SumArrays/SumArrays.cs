using System;
using System.Collections.Generic;
using System.Linq;

namespace SumArrays
{
    public class SumArrays
    {
        public static void Main()
        {
            int[] array1 = Console.ReadLine()
                .Trim()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] array2 = Console.ReadLine()
                .Trim()
                .Split()
                .Select(int.Parse)
                .ToArray();

            
            if (array1.Length < array2.Length)
            {
                AddToShortArray(array1, array2);
            }
            else
            {
                AddToShortArray(array2, array1);
            }
        }

        private static void AddToShortArray(int[] shortArray, int[] longArray)
        {
            List<int> addToShort = new List<int>();
            for (int i = 0; i < longArray.Length; i++)
            {
                addToShort.Add(shortArray[i%shortArray.Length]);
            }

            for (int i = 0; i < addToShort.Count; i++)
            {
                longArray[i] += addToShort[i];
            }

            Console.WriteLine(string.Join(" ", longArray));
        }
    }
}
