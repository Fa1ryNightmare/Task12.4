using System.Threading;

namespace Task12_4
{
    delegate void StartTimerEvent(object sender, string name);
    delegate void TimerEvent(int time);
    delegate void FinishTimerEvent(string name);

    class Timer
    {
        public event StartTimerEvent Start = null;
        public event TimerEvent Countdown = null;
        public event FinishTimerEvent Finish = null;

        string timerName;
        int time;

        public Timer(int time, string timerName)
        {
            this.time = time;
            this.timerName = timerName;
        }

        public void Count()
        {
            if (Start != null && Countdown != null && Finish != null)
            {
                Start(this, timerName);
                for (int i = time; i != 0; i--)
                {
                    Countdown(i);
                    Thread.Sleep(1000);
                }
                Finish(timerName);
            } 
        }
    }
}