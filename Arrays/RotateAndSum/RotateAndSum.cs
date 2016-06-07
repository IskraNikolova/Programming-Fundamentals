using System;
using System.Linq;

namespace RotateAndSum
{
    public class RotateAndSum
    {
        public static void Main()
        {
            int[] arrayToRotate = Console.ReadLine()
                .Trim()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int r = int.Parse(Console.ReadLine()
                .Trim());

            int lengthOfArray = arrayToRotate.Length;
            int[] sumOfRotations = new int[lengthOfArray];
            int[] rotations = new int[lengthOfArray];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < lengthOfArray; j++)
                {
                    int newPosition = (j + lengthOfArray - 1)% lengthOfArray;
                    rotations[j] = arrayToRotate[newPosition];
                    sumOfRotations[j] += rotations[j];
                }   
                
                Array.Copy(rotations, arrayToRotate, lengthOfArray);        
            }

            Console.WriteLine(string.Join(" ", sumOfRotations));
        }
    }
}
