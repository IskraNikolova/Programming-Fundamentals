namespace CenturiesToMinutes
{
    using System;

    public class CentriesToMinutes
    {
        private const int CountOfYearInCentries = 100;
        private const double DaysInOneYear = 365.2422;
        private const int HoursInOneDay = 24;
        private const int MinutesInOneHour = 60;

        public static void Main(string[] args)
        {
            int centries = int.Parse(Console.ReadLine());
            int year = CalculateYears(centries);
            int days = CalculateDaysInYears(year);
            int hours = CalculateHours(days);
            int minutes = CalculateMinutes(hours);

            PrintResult(centries, year, days, hours, minutes);
        }

        private static void PrintResult(int centries, int year, int days, int hours, int minutes)
        {
            Console.WriteLine($"{centries}\n{year}\n{days}\n{hours}\n{minutes}");
        }

        private static int CalculateMinutes(int hours)
        {
            int minutes = hours * MinutesInOneHour;

            return minutes;
        }

        private static int CalculateHours(int days)
        {
            int hours = days * HoursInOneDay;

            return hours;
        }

        private static int CalculateDaysInYears(int year)
        {
            double days = year * DaysInOneYear;

            return (int)days;
        }

        private static int CalculateYears(int centries)
        {
            int year = centries * CountOfYearInCentries;

            return year;
        }
    }
}