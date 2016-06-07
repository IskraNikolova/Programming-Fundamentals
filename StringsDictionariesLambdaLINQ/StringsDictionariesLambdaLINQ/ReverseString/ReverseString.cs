using System;
using System.Linq;

namespace ReverseString
{
    public class ReverseString
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var reverse = input.ToCharArray().Reverse();
            Console.WriteLine(string.Join("", reverse));
        }
    }
}
