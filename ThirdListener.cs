using System;

namespace Task12_4
{
    class ThirdListener : ICutDownNotifier
    {
        Timer timer;

        public ThirdListener(int time, string timerName)
        {
            timer = new Timer(time, timerName);
        }

        void ICutDownNotifier.Init()
        {
            timer.Start += (object sender, string name) => Console.WriteLine($"Таймер {name} запущен");
            timer.Countdown += (int time) => Console.WriteLine($"Осталось {time} секунд");
            timer.Finish += (string name) => Console.WriteLine($"Таймер {name} закончил отсчёт");
        }

        void ICutDownNotifier.Run()
        {
            timer.Count();
        }
    }
}
