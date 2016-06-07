using System;

namespace RectangleProperties
{
    public class RectangleProparties
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine().Trim());
            double b = double.Parse(Console.ReadLine().Trim());

            double perimeter = (2*a) + (2*b);
            Console.WriteLine(perimeter);

            double area = a*b;
            Console.WriteLine(area);

            double diagonalLength = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine(diagonalLength);
        }
    }
}
