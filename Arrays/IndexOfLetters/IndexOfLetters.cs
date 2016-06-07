using System;
using System.Collections.Generic;

namespace IndexOfLetters
{
    public class IndexOfLetters
    {
        public static void Main()
        {
            Dictionary<char, int> alphabet = new Dictionary<char, int>();
            char a = (char) 97;
            for (int i = 0; i < 26; i++)
            {
                char element = a++;
                alphabet.Add(element, i);
            }

            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                int pairValue = alphabet[input[i]];
                Console.WriteLine($"{input[i]} -> {pairValue}");
            }
        }
    }
}
