using System;
using System.Linq;

namespace LargestCommonEnd
{
    public class LargestCommonEnd
    {
        public static void Main()
        {
            string[] firstArray = Console.ReadLine().Trim().Split();
            string[] secondArray = Console.ReadLine().Trim().Split();

            int length = firstArray.Length > secondArray.Length ? secondArray.Length : firstArray.Length;
 
            int maxCountRight = 0;
            for (int i = 0; i < length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    maxCountRight++;
                }
            }

            if (length == secondArray.Length)
            {
                firstArray = CutLongestArray(firstArray, secondArray);
            }
            else
            {
                secondArray = CutLongestArray(secondArray, firstArray);
            }

            int maxCountLeft = 0;
            for (int i = length - 1; i >= 0; i--)
            {
                if (firstArray[i] == secondArray[i])
                {
                    maxCountLeft++;
                }
            }

            Console.WriteLine(maxCountRight >= maxCountLeft ? maxCountRight : maxCountLeft);
        }

        private static string[] CutLongestArray(string[] firstArray, string[] secondArray)
        {
            int skipLength = firstArray.Length - secondArray.Length;
            int length = secondArray.Length;
            return firstArray.Skip(skipLength).Take(length).ToArray();
        }
    }
}
