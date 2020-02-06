using System;

namespace TimeElapsedCounter
{
    public interface IEvent
    {
        
        DateTime EventDate { get; set; }
        string Title { get; set; }
        TimeSpan ElapsedMissing{ get; set; }
    }
}