namespace SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            List<double> input =
                Console.ReadLine()
                    .Trim()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToList();

            bool isEquals = true;
            while (isEquals)
            {
                isEquals = false;  
                for (int i = 0; i < input.Count - 1; i++)
                {
                    if(input[i] == input[i + 1])
                    {
                        double sum = input[i] + input[i + 1];
                        input.RemoveRange(i, 2);
                        input.Insert(i, sum);
                        isEquals = true;
                    }
                }
            }
        
        Console.WriteLine(string.Join(" ", input));

        }
    }
}
