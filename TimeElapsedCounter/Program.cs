using System;
using System.Collections.Generic;

namespace TimeElapsedCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string Route = "F:\\EventDates.txt";
            char separator = ',';
            Clock clock = new Clock();
            EventReader @event = new EventReader(Route, separator, clock);
            DateStringBuilder stringBuilder = new DateStringBuilder();
            EventWriter eventWriter = new EventWriter(stringBuilder);

            List<IEvent> eventList = @event.ReadEventDocument();
            eventWriter.Printconsole(eventList);
            Console.ReadLine();
        }
    }

}
