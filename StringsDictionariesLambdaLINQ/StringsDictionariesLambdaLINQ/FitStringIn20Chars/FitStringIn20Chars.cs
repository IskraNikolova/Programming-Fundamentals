using System;

namespace FitStringIn20Chars
{
    public class FitStringIn20Chars
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.Length < 20)
            {
                Console.WriteLine(input.PadRight(20, '*'));
            }
            else if (input.Length > 20)
            {
                Console.WriteLine(input.Substring(0, 20));
            }
            

        }
    }
}
