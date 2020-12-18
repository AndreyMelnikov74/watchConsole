using System;
using System.Threading.Tasks;
using System.Threading;

namespace watchConsole
{
    class WatchScreenSaver
    {

        static int lengthtext = 0;
        
        // Метод для отображения screen saver.
        public void ScreenSaver(object ScreenSaver)
        {
            if(lengthtext == 0) Console.Beep(8000, 1000);
            string[] textscreensaver = new string[] { "Ч", "А", "С", "Ы", " ", "в", "е", "р", "с", "и", "я", " ", "1", ".", "0", "\r\n" };
            if(lengthtext < textscreensaver.Length) Console.Write(textscreensaver[lengthtext]);
            lengthtext++;
        }

        // Метод для таймера.
        public void TimerScreenSaver()
        {
            Timer timer = new Timer(callback: new TimerCallback(ScreenSaver), null, 0, 2000);
            while(lengthtext < 17)
            {
                Task.Delay(1000).Wait();
            }
            timer.Dispose();
        }
    }
}
