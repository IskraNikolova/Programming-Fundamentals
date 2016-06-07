using System;

namespace Elevator
{
    public class Elevator
    {
        public static void Main()
        {
            double numberOfPeople = double.Parse(Console.ReadLine().Trim());
            double capacity = double.Parse(Console.ReadLine().Trim());

            int courses = CalculateCoursesWillBeNeeded(numberOfPeople, capacity);
            Console.WriteLine(courses);
        }

        private static int CalculateCoursesWillBeNeeded(double numberOfPeople, double capacity)
        {
            double result = Math.Ceiling(numberOfPeople/capacity);

            return (int) result;
        }
    }
}
