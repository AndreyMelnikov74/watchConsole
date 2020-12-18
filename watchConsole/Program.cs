using System;

namespace watchConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ЧАСЫ";
            WatchScreenSaver watchscreensaver = new WatchScreenSaver();
            watchscreensaver.TimerScreenSaver();
            CalendarWatch calendarwatch = new CalendarWatch();
            calendarwatch.TimerCalendarWatch();
        }
    }
}
