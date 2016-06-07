using System;

namespace StringsAndObjects
{
    public class StringsAndObjects
    {
        public static void Main()
        {
            string firstStringForConcat = "Hello";
            string secondStringForConcat = "World";

            object result = firstStringForConcat + " " + secondStringForConcat;
            Console.WriteLine(result);
        }
    }
}
