using System.Collections.Generic;

namespace TimeElapsedCounter
{
    public interface IEventWriter
    {
        void Printconsole(List<IEvent> events);
    }
}