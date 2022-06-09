using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerExecutionMethod
{
    public class Timer
    {
        public FixedUpdate fixedUpdate;
        private bool _isRunning = false;
        private int _delay;

        public Timer(int delay)
        {
            _delay = delay;
        }

        public void Start()
        {
            _isRunning = true;
            Ticker();
        }

        public void Stop()
        {
            _isRunning = false;
        }

        private void Ticker()
        {
            while (_isRunning)
            {
                fixedUpdate();
                Thread.Sleep(_delay);
            }
        }
    }
}
