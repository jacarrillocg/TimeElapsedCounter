using System;
using System.Collections.Generic;

namespace TimeElapsedCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string Route = "C:/";
            char separator = ',';
            EventReader @event = new EventReader(Route, separator);
            List<IEvent> eventList = @event.ReadEventDocument();

        }
    }

    public class PrintEvents
    {
        private List<IEvent> _events;
        public PrintEvents(List<IEvent> events)
        {
            _events = events;
        }

        public void printEvents()
        {

        }
    }

}
