using System;

namespace VariableInHexadecimalFormat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string numberInHexadecimalFormat = Console.ReadLine().Trim();
            int decimalFormat = Convert.ToInt16(numberInHexadecimalFormat, 16);
            Console.WriteLine(decimalFormat);
        }
    }
}
