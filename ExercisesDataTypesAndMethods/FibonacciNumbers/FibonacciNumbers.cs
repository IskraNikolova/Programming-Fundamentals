namespace FibonacciNumbers
{
    using System;
    using System.Numerics;

    public class FibonacciNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine().Trim());
           
            if (n == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                BigInteger firstNumber = 0;
                BigInteger secondNumber = 1;
                BigInteger thirdNumber = 0;

                for (int index = 0; index < n; index++)
                {
                    thirdNumber = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                }

                Console.WriteLine(secondNumber);
            }
        }
    }
}