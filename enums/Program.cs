using System;

namespace enums
{
    class Program
    {

        // Kan skapa egna enums såhär:
        enum WeekDay
        {
            // Databaser (i af SQL) förstår inte enum så till den behöver skicka in intar (t. ex?)
            Monday = 10, Tuesday = 20
        }
        static void Main(string[] args)
        {
            AddCalendarEvent("Do something", DayOfWeek.Monday, WeekDay.Monday);
        }

        static void AddCalendarEvent(string eventName, DayOfWeek dayOfWeek, WeekDay weekDay)
        {
            // Genom att skriva switch tab tab och sedan lägger in dayOfWeek i parentesen och trycker Enter Enter så printas hela färdiga switch statement ut enligt nedan:
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine(eventName);
                    Console.WriteLine((int)dayOfWeek); // 1
                    Console.WriteLine((int)weekDay); // 10 (se ovan)
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                default:
                    break;
            }
        }
    }
}
