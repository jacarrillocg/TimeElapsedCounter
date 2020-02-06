using System;

namespace TimeElapsedCounter
{
    public class Event : IEvent
    {
        public string Title { get; set; }

        public DateTime EventDate { get; set; }
        public DateTime Elapsedtime { get; set; }

        public DateTime Missingtime { get; set; }

    }

}
