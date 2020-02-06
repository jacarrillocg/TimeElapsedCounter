using System;
using System.Collections.Generic;
using System.Text;
using TimeElapsedCounter.Interfaces;

namespace TimeElapsedCounter
{
    public class Clock : IClock
    {
        public DateTime Getcurrenttime()
        {
            return DateTime.Now;
        }
    }
}
