using System;

namespace DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine().Trim());

            string day = TakeDayOfWeekWithNumber(input);

            Console.WriteLine(day);
        }

        private static string TakeDayOfWeekWithNumber(int input)
        {
            string dayOfWeek = string.Empty;
            switch (input)
            {
                case 1:
                    dayOfWeek = "Monday";
                    break;
                case 2:
                    dayOfWeek = "Tuesday";
                    break;
                case 3:
                    dayOfWeek = "Wednesday";
                    break;
                case 4:
                    dayOfWeek = "Thursday";
                    break;
                case 5:
                    dayOfWeek = "Friday";
                    break;
                case 6:
                    dayOfWeek = "Saturday";
                    break;
                case 7:
                    dayOfWeek = "Sunday";
                    break;
                default:
                    dayOfWeek = "Error";
                    break;
            }

            return dayOfWeek;
        }
    }
}
