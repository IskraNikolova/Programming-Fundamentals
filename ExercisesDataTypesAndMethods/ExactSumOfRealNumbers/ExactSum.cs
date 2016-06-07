using System;

namespace ExactSumOfRealNumbers
{
    public class ExactSum
    {
        public static void Main()
        {
            int length = int.Parse(Console.ReadLine().Trim());

            decimal sum = 0;
            sum = CalculateSumOfRealNumber(length, sum);

            Console.WriteLine(sum);
        }

        private static decimal CalculateSumOfRealNumber(int length, decimal sum)
        {
            for (int i = 0; i < length; i++)
            {
                decimal addend = decimal.Parse(Console.ReadLine().Trim());
                sum += addend;
            }

            return sum;
        }
    }
}
