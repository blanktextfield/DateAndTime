using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine($"Today: {today}");
            int yearToday = today.Year;
            Console.WriteLine($"Current year from today {yearToday}");
            var weekDayToday = today.DayOfWeek;
            Console.WriteLine($"It`s {weekDayToday}!");
            Console.WriteLine("-------------------");

            DateTime todayDetails = DateTime.Now;
            Console.WriteLine($"Today in details: {todayDetails}");
            DateTime utc = DateTime.UtcNow;

            DateTime xmasEve = new DateTime(2020, 12, 24);
            var xmasDayOfWeek = xmasEve.DayOfWeek;
            Console.WriteLine($"This year Xmas Eve is on {xmasDayOfWeek}");



        }
    }
}
