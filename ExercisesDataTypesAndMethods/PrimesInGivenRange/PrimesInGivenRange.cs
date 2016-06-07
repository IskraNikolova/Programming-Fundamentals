using System;
using System.Collections.Generic;

namespace PrimesInGivenRange
{
    public class PrimesInGivenRange
    {
        public static void Main()
        {
            int startRange = int.Parse(Console.ReadLine().Trim());
            int endRange = int.Parse(Console.ReadLine().Trim());
            List<int> primeNumbers = new List<int>();
            for (int num = startRange; num <= endRange; num++)
            {
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
                if (prime && num != 0 && num != 1)
                {
                    primeNumbers.Add(num);
                }
            }

            Console.WriteLine(string.Join(", ", primeNumbers));
        }
    }
}
