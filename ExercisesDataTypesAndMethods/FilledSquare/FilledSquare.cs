using System;

namespace FilledSquare
{
    public class FilledSquare
    {
        public static void Main()
        {
            int countOfRowsSquare = int.Parse(Console.ReadLine().Trim());

            DrawSquare(countOfRowsSquare);
        }

        private static void DrawSquare(int countOfRowsSquare)
        {
            string firstAndLastLine = new string('-', countOfRowsSquare * 2);
            Console.WriteLine(firstAndLastLine);
            string innerPattern = "\\/";
            int countOfInnerPattern = ((countOfRowsSquare*2) - 2)/2;
            for (int i = 0; i < countOfRowsSquare - 2; i++)
            {
                string innerInnerLine = string.Empty;
                for (int j = 0; j < countOfInnerPattern; j++)
                {
                    innerInnerLine += innerPattern;
                }

                Console.WriteLine($"-{innerInnerLine}-");
            }

            Console.WriteLine(firstAndLastLine);
        }
    }
}
