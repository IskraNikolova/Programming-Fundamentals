using System;

namespace ConvertSpeedUnits
{
    public class ConvertSpeedUnits
    {
        public static void Main()
        {
           float  distance = float.Parse(Console.ReadLine().Trim());
           float hours = float.Parse(Console.ReadLine().Trim());
           float  minutes = float.Parse(Console.ReadLine().Trim());
           float  seconds = float.Parse(Console.ReadLine().Trim());

            var metersPerSecond = CalculateMetersPerSecond(distance, seconds, minutes, hours)
                .ToString()
                .TrimEnd('0', ' ')
                .Trim();
            Console.WriteLine($"{metersPerSecond:C7}");

            var kmPerHours = CalculateKilometerPerHour(distance, seconds, minutes, hours)
              .ToString()
              .TrimEnd('0', ' ')
              .Trim();
            Console.WriteLine($"{kmPerHours:C7}");

            var milesPerHours = CalculateMilesPerHours(distance, seconds, minutes, hours)
             .ToString()
             .TrimEnd('0', ' ')
             .Trim();
            Console.WriteLine($"{milesPerHours:C7}");
        }

        private static float CalculateMetersPerSecond(float distance, float seconds, float minutes, float hours)
        {
            float hourToMinutes = hours * 60;
            float hourToSeconds = hourToMinutes * 60;
            float minuteToSeconds = minutes * 60;
            float allSeconds = seconds + minuteToSeconds + hourToSeconds;

            float result = distance / allSeconds;
            return result;
        }

        private static float CalculateKilometerPerHour(float distance, float seconds, float minutes, float hours)
        {
            float allHours = hours + (minutes/60) + ((seconds/60)/60);
            float km = distance/1000;

            float result = km/allHours;

            return result;
        }

        private static float CalculateMilesPerHours(float distance, float seconds, float minutes, float hours)
        {
            float allHours = hours + (minutes / 60) + ((seconds / 60) / 60);
            float miles = distance / 1609;

            float result = miles/allHours;
            return result;
        }
    }
}
