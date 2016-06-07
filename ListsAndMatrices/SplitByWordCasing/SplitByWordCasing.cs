using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitByWordCasing
{
    public class SplitByWordCasing
    {
        public static void Main()
        {
            List<string> input =
                Console.ReadLine()
                    .Split(new char[] {',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' '},
                        StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();
        
            for (int i = 0; i < input.Count; i++)
            {
                bool isUpper = true;
                bool isLower = true;
                bool isMix = false;
                for (int j = 0; j < input[i].Length; j++)
                {
                    if (char.IsLetter(input[i][j]))
                    {
                        if (char.IsLower(input[i][j]))
                        {
                            isUpper = false;
                        }
                        else if (char.IsUpper(input[i][j]))
                        {
                            isLower = false;
                        }
                    }
                    else
                    {
                        isMix = true;
                    }
                }

                if (isLower && !isMix)
                {
                    lowerCase.Add(input[i]);
                }
                else if (isUpper && !isMix)
                {
                    upperCase.Add(input[i]);
                }
                else
                {
                    mixedCase.Add(input[i]);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
