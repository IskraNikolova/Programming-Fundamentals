using System;

namespace VowelOrDigit
{
    public class VowelOrDigit
    {
        public static void Main()
        {
            string input = Console.ReadLine().Trim();
            string result = string.Empty;
            if(char.IsDigit(input[0]))
            {
                result = "digit";
            }
            else
            {
                switch (input)
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                    case "y":
                        result = "vowel";
                        break;
                    default:
                        result = "other";
                        break;
                }
            }

            Console.WriteLine(result);         
        }
    }
}
