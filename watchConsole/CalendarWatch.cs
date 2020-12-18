using System;
using System.Threading;

namespace watchConsole
{
    class CalendarWatch
    {

        // Метод для отображения календаря и часов.
        public void WriteCalendarWatch(object WriteCalendarWatch)
        {
            Console.Clear();
            // Вывод на экран даты и времени.
            Console.Write("{6}    {0}.{1}.{2}    {3}:{4}:{5}\r\n", DateTime.Now.Day, 
                DateTime.Now.Month, 
                DateTime.Now.Year, 
                DateTime.Now.Hour, 
                DateTime.Now.Minute, 
                DateTime.Now.Second, 
                DateTime.Now.DayOfWeek);
        }

        // Метод для таймера.
        public void TimerCalendarWatch()
        {
            Timer timercalendarwatch = new Timer(callback: new TimerCallback(WriteCalendarWatch), null, 0, 5000);
            Console.ReadKey();
            timercalendarwatch.Dispose();
        }
    }
}
