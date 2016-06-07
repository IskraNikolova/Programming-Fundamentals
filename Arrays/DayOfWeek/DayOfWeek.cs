using System;

namespace DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main()
        {
            string[] dayOfWeek = new[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int day = int.Parse(Console.ReadLine().Trim());
            try
            {
                Console.WriteLine(dayOfWeek[day - 1]);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
