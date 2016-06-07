namespace CompareCharArrays
{
    using System;
    using System.Linq;

    public class CompareCharArrays
    {
        public static void Main(string[] args)
        {
            char[] array1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] array2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            string arr1 = string.Join("", array1);
            string arr2 = string.Join("", array2);
            string[] orderedArrays = new string[2];
            orderedArrays[0] = arr1;
            orderedArrays[1] = arr2;

            var order = orderedArrays.OrderBy(l => l);
            foreach (var element in order)
            {
                Console.WriteLine(element);
            }
        }
    }
}
