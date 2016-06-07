using System;

namespace PrimeChecker
{
    public class PrimeChecker
    {
        public static void Main()
        {
            long num = long.Parse(Console.ReadLine().Trim());
            if (num == 0 || num == 1)
            {
                Console.WriteLine(false);
                return;
            }

            int divider = 2;
            int maxDivider = (int)Math.Sqrt(num);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (num % divider == 0)
                {
                    prime = false;
                }

                divider++;
            }

            Console.WriteLine(prime);
        }
    }
}
