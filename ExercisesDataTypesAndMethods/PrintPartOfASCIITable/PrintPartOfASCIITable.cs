using System;

namespace PrintPartOfASCIITable
{
    public class PrintPartOfASCIITable
    {
        public static void Main()
        {
            int startIndex = int.Parse(Console.ReadLine().Trim());
            int lastIndex = int.Parse(Console.ReadLine().Trim());

            for (int i = startIndex; i <= lastIndex; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
