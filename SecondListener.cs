using System;

namespace Task12_4
{
    class SecondListener : ICutDownNotifier
    {
        Timer timer;

        public SecondListener(int time, string timerName)
        {
            timer = new Timer(time, timerName);
        }

        void ICutDownNotifier.Init()
        {
            timer.Start += delegate (object sender, string name)
            {
                Console.WriteLine($"Таймер {name} запущен");
            };
            timer.Countdown += delegate (int time)
            {
                Console.WriteLine($"Осталось {time} секунд");
            };
            timer.Finish += delegate (string name)
            {
                Console.WriteLine($"Таймер {name} закончил отсчёт");
            };
        }

        void ICutDownNotifier.Run()
        {
            timer.Count();
        }
    }
}
