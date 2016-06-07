namespace NumbersInReversedOrder
{
    using System;
    using System.Linq;

    public class NumbersInReverseOrder
    {
        public static void Main()
        {
            string input = Console.ReadLine().Trim();
            var reverseNumber = input.Reverse();

            Console.WriteLine(string.Join("", reverseNumber));
        }
    }
}
