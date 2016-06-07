using System;
using System.Collections.Generic;
using System.Linq;

namespace SpecialNumbers
{
    public class SpecialNumbers
    {
        public static void Main()
        {
            string inputStringNumber = Console.ReadLine().Trim();
            int inputNumber = int.Parse(inputStringNumber);


            for (int i = 1; i <= inputNumber; i++)
            {
                List<int> digits = new List<int>();
                string number = i.ToString();
                for (int j = 0; j < number.Length; j++)
                {
                    int digit = int.Parse(number[j].ToString());
                    digits.Add(digit);
                }

                int sum = digits.Sum(c => c);
                bool isSpecialNumber = IsSpecialNumber(sum);

                Console.WriteLine($"{i} -> {isSpecialNumber}");
            }


        }

        private static bool IsSpecialNumber(int sum)
        {
            switch (sum)
            {
                case 5:
                case 7:
                case 11:
                    return true;
                default:
                    return false;
            }
        }
    }
}
