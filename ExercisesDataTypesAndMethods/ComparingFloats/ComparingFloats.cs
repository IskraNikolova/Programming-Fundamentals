using System;

namespace ComparingFloats
{
    public class ComparingFloats
    {
        public static void Main()
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine().Trim());
            decimal secondNumber = decimal.Parse(Console.ReadLine().Trim());

            decimal diff = Math.Abs(firstNumber - secondNumber);
            if (diff >= 0.000001m)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
        }
    }
}
