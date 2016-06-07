using System;

namespace CircleArea12Digits_Precision
{
    public class CircleArea12DigitsPrecision
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine().Trim());
            var area = CalculateAreaOfCircle(radius);
            Console.WriteLine($"{area:F12}");
        }

        private static double CalculateAreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
    }
}