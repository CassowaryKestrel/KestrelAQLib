using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KestrelAQLib.Default_Actions
{
    public class A_WaitForTime : Action
    {
        private Task _timer;
        private int _time;

        public A_WaitForTime(int milliseconds)
        {
            _time = milliseconds;
        }

        public override bool Tick()
        {
            return _timer.IsCompletedSuccessfully;
        }

        public override void whenStarted()
        {
            _timer = Task.Run(() => Thread.Sleep(_time));
        }

        public override string ToString()
        {
            return "Waiting for " + _time.ToString() + " milliseconds";
        }
    }

}
