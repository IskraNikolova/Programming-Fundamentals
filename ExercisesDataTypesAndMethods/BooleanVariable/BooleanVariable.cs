using System;

namespace BooleanVariable
{
    public class BooleanVariable
    {
        public static void Main()
        {
            string input = Console.ReadLine();
 
            bool convertedInput = Convert.ToBoolean(input);

            Console.WriteLine(convertedInput ? "Yes" : "No");
        }
    }
}
