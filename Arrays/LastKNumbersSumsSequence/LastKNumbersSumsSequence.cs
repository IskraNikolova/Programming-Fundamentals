using System;
using System.Collections.Generic;

namespace LastKNumbersSumsSequence
{
    public class LastKNumbersSumsSequence
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine().Trim());
            int k = int.Parse(Console.ReadLine().Trim());

            List<long> result = new List<long>();
            result.Add(1);

            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                int index = k;
                for (int j = 1; j <= result.Count; j++)
                {
                    if (index == 0)
                    {
                        break;
                    }

                    sum += result[i - j];
                    index--;
                }

                result.Add(sum);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
