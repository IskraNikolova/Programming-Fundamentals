using System;

namespace MaxMethod
{
    public class MaxMethod
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine().Trim());
            int secondNumber = int.Parse(Console.ReadLine().Trim());
            int thirdNumber = int.Parse(Console.ReadLine().Trim());
            int firstCheck = GetMax(firstNumber, secondNumber);
            int result = GetMax(firstCheck, thirdNumber);
            Console.WriteLine(result);
        }

        private static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }
    }
}
