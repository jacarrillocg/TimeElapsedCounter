using System.Collections.Generic;

namespace TimeElapsedCounter
{
    public interface IEventReader
    {
        List<IEvent> ReadEventDocument();
    }
}