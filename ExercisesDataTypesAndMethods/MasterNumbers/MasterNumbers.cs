namespace MasterNumbers
{
    using System;
    using System.Linq;

    public class MasterNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine().Trim());

            for (int i = 1; i < n; i++)
            {
                string numberToString = i.ToString();
                bool isPalindrom = CheckIsPalindrom(numberToString);
                if (isPalindrom)
                {
                    bool isDigitsSumDivideBySeven = CheckIsDivideBySeven(numberToString);
                    if (isDigitsSumDivideBySeven)
                    {
                        bool isHoldsEvenDigit = CheckIsHoldEvenDigit(numberToString);
                        if (isHoldsEvenDigit)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }           
            }
        }

        private static bool CheckIsHoldEvenDigit(string numberToString)
        {
            for (int i = 0; i < numberToString.Length; i++)
            {
                int digit = int.Parse(numberToString[i].ToString());
                if (digit % 2 == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool CheckIsDivideBySeven(string numberToString)
        {
            int sum = 0;
            for (int i = 0; i < numberToString.Length; i++)
            {
                int digit = int.Parse(numberToString[i].ToString());
                sum += digit;
            }

            if (sum % 7 == 0)
            {
                return true;
            }

            return false;
        }

        private static bool CheckIsPalindrom(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }

                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }

                min++;
                max--;
            }
        }
    }
}
