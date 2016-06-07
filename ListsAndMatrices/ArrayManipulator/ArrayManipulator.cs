using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            List<long> inputArray =
                Console.ReadLine()
                    .Trim()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToList();

            string command = Console.ReadLine().Trim();
            while (command != "print")
            {
                string[] data = command.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                int index = 0;
                long element = 0;
                switch (data[0])
                {
                    case "add":
                        index = int.Parse(data[1]);
                        element = int.Parse(data[2]);
                        AddElement(inputArray, index, element);
                        break;
                    case "addMany":
                        AddMany(inputArray, data);
                        break;
                    case "contains":
                        element = long.Parse(data[1]);
                        long isContains = IsContains(inputArray, element);
                        Console.WriteLine(isContains);
                        break;
                    case "remove":
                        index = int.Parse(data[1]);
                        Remove(inputArray, index);
                        break;
                    case "shift":
                        int position = int.Parse(data[1]);
                        Shift(inputArray, position);
                        break;
                    case "sumPairs":
                        SumPairs(inputArray);
                        break;
                }

                command = Console.ReadLine().Trim();
            }

            Console.WriteLine($"[{string.Join(", ", inputArray)}]");
        }

        private static void SumPairs(List<long> inputArray)
        {
            List<long> sum = new List<long>();
            for (int i = 0; i < inputArray.Count - 1; i = i + 2)
            {
                sum.Add(inputArray[i] + inputArray[i + 1]);
            }
            if (inputArray.Count % 2 == 0)
            {
                inputArray.Clear();
                inputArray.AddRange(sum);
            }
            else
            {
                inputArray.RemoveRange(0, inputArray.Count - 1);
                inputArray.InsertRange(0, sum);
            }
           
        }

        private static void Shift(List<long> inputArray, int position)
        {
            int count = position % inputArray.Count;
            var part2 = inputArray.Take(count).ToList();
            inputArray.RemoveRange(0, count);
            inputArray.AddRange(part2);
        }

        private static void Remove(List<long> inputArray, int index)
        {
            inputArray.RemoveAt(index);
        }

        private static int IsContains(List<long> inputArray, long element)
        {
            bool contains = inputArray.Contains(element);
            if (contains)
            {
                return inputArray.IndexOf(element);
            }

            return -1;
        }

        private static void AddMany(List<long> inputArray, string[] data)
        {
            int index = int.Parse(data[1]);
            List<long> collectionForAdding = new List<long>();
            for (int i = 2; i < data.Length; i++)
            {
                collectionForAdding.Add(int.Parse(data[i]));
            }

            inputArray.InsertRange(index, collectionForAdding);
        }

        private static void AddElement(List<long> array, int index, long element)
        {
            array.Insert(index, element);
        }
    }
}
