using System;
using System.Linq;

namespace ReverseChars
{
    public class ReverseChars
    {
        public static void Main()
        {
            string result = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                string inputLine = Console.ReadLine().Trim();
                result += inputLine;
            }

            var reversedString = result.Reverse();
            Console.WriteLine(string.Join("", reversedString));
        }
    }
}
