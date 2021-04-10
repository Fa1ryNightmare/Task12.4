using System;

namespace Task12_4
{
    class FirstListener : ICutDownNotifier
    {
        Timer timer;

        public FirstListener(int time, string timerName)
        {
            timer = new Timer(time, timerName);
        }
        
        void ICutDownNotifier.Init()
        {
            timer.Start += ListenerStart;
            timer.Countdown += ListenerCountdown;
            timer.Finish += ListenerCountdown;
        }

        void ICutDownNotifier.Run()
        {
            timer.Count();
        }

        private void ListenerStart(object sender, string name)
        {
            Console.WriteLine($"Таймер {name} запущен");
        }

        private void ListenerCountdown(int time)
        {
            Console.WriteLine($"Осталось {time} секунд");
        }

        private void ListenerCountdown(string name)
        {
            Console.WriteLine($"Таймер {name} закончил отсчёт");
        }
    }
}
