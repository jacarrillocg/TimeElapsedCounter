using System;

namespace TimeElapsedCounter
{
    public class Event : IEvent
    {
        public string Title { get; set; }

        public DateTime EventDate { get; set; }
        public TimeSpan ElapsedMissing { get; set; }
    }

}
