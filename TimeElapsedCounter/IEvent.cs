using System;

namespace TimeElapsedCounter
{
    public interface IEvent
    {
        DateTime Elapsedtime { get; set; }
        DateTime EventDate { get; set; }
        string Title { get; set; }
        DateTime Missingtime { get; set; }
    }
}