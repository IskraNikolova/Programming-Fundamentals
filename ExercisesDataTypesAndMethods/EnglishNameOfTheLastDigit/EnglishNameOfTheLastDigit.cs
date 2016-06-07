using System;
using System.CodeDom;

namespace EnglishNameOfTheLastDigit
{
    public class EnglishNameOfTheLastDigit
    {
        public static void Main()
        {
            //decimal inputNumber = decimal.Parse(Console.ReadLine().Trim());
            //int lastDigit = (int)(inputNumber%10);

            string input = Console.ReadLine().Trim();
            char lastDigit = input[input.Length - 1];

            Console.WriteLine(GetNameByDigit(lastDigit));
        }

        private static string GetNameByDigit(char digit)
        {
            string name = string.Empty;
            switch (digit)
            {
                case '0':
                    name = "zero";
                    break;
                case '1':
                    name = "one";
                    break;
                case '2':
                    name = "two";
                    break;
                case '3':
                    name = "three";
                    break;
                case '4':
                    name = "four";
                    break;
                case '5':
                    name = "five";
                    break;
                case '6':
                    name = "six";
                    break;
                case '7':
                    name = "seven";
                    break;
                case '8':
                    name = "eight";
                    break;
                case '9':
                    name = "nine";
                    break;
            }

            return name;
        }
    }
}
