namespace ReverseAnArrayOfIntegers
{
    using System;
    using System.Linq;

    public class ReverseAnArrayOfIntegers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine().Trim());

            int[] input = new int[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine().Trim());
            }

            var reverseArray = input.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", reverseArray));
        }
    }
}
