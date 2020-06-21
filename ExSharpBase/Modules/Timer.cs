using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace ExSharpBase.Modules
{
    class Timer
    {
        public static readonly double TickLength = 1000f / Stopwatch.Frequency;
        public static readonly double Frequency = Stopwatch.Frequency;
        public static bool IsHighResolution = Stopwatch.IsHighResolution;
        public event EventHandler<TimerElapsedEventArgs> Elapsed;

        private volatile float _interval;
        private volatile bool _isRunning;
        private Thread _thread;

        public Timer() : this(1f)
        {
        }
        public Timer(float interval)
        {
            Interval = interval;
        }
        public float Interval
        {
            get => _interval;
            set
            {
                if (value < 0f || Single.IsNaN(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                _interval = value;
            }
        }

        public bool IsRunning => _isRunning;
        public bool UseHighPriorityThread { get; set; } = false;
        public void Start()
        {
            if (_isRunning) return;

            _isRunning = true;
            _thread = new Thread(ExecuteTimer)
            {
                IsBackground = true,
            };

            if (UseHighPriorityThread)
            {
                _thread.Priority = ThreadPriority.Highest;
            }
            _thread.Start();
        }
        public void Stop(bool joinThread = true)
        {
            _isRunning = false;
            if (joinThread && Thread.CurrentThread != _thread)
            {
                _thread.Join();
            }
        }
        private void ExecuteTimer()
        {
            float nextTrigger = 0f;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (_isRunning)
            {
                nextTrigger += _interval;
                double elapsed;

                while (true)
                {
                    elapsed = ElapsedHiRes(stopwatch);
                    double diff = nextTrigger - elapsed;
                    if (diff <= 0f)
                        break;

                    if (diff < 1f)
                        Thread.SpinWait(10);
                    else if (diff < 5f)
                        Thread.SpinWait(100);
                    else if (diff < 15f)
                        Thread.Sleep(1);
                    else
                        Thread.Sleep(10);

                    if (!_isRunning)
                        return;
                }


                double delay = elapsed - nextTrigger;
                Elapsed?.Invoke(this, new TimerElapsedEventArgs(delay));

                if (!_isRunning)
                    return;

                if (stopwatch.Elapsed.TotalHours >= 1d)
                {
                    stopwatch.Restart();
                    nextTrigger = 0f;
                }
            }

            stopwatch.Stop();
        }

        private static double ElapsedHiRes(Stopwatch stopwatch)
        {
            return stopwatch.ElapsedTicks * TickLength;
        }
    }


    internal class TimerElapsedEventArgs : EventArgs
    {
        public double Delay { get; }

        internal TimerElapsedEventArgs(double delay)
        {
            Delay = delay;
        }
    }
}
