using System;

namespace IntegerToHexAndBinary
{
    public class IntegerToHexAndBinary
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine().Trim());

            string hexadecimalNumber = Convert.ToString(inputNumber, 16).ToUpper();
            Console.WriteLine(hexadecimalNumber);

            string binaryNumber = Convert.ToString(inputNumber, 2);
            Console.WriteLine(binaryNumber);
        }
    }
}
