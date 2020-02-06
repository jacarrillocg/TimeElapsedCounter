using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TimeElapsedCounter.Interfaces;

namespace TimeElapsedCounter
{
    public class EventReader : IEventReader
    {
        private string _txtRoute;
        private char _separator;
        private IClock _clock;
        public EventReader(string txtRoute, char separatorChar, IClock clock)
        {
            _txtRoute = txtRoute;
            _separator = separatorChar;
            _clock = clock;
        }

        public List<IEvent> ReadEventDocument()
        {
            var path = _txtRoute;

            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            List<IEvent> Events = new List<IEvent>();

            foreach (string line in lines)
            {
                CreateEvent(Events, line);
            }

            return Events;
        }

        private void CreateEvent(List<IEvent> Events, string line)
        {
            string[] splitedArray = line.Split(_separator);
            if (splitedArray.Length >= 2)
            {
                Event @event = new Event();

                @event.Title = splitedArray[0].ToStringNotEmpty();
                @event.EventDate = splitedArray[1].ToDateTime();
                 @event.ElapsedMissing= GetMissingElapsedtime(@event.EventDate);

                Events.Add(@event);
            }
        }

        private TimeSpan GetMissingElapsedtime(DateTime eventDate)
        {
            TimeSpan  time = _clock.Getcurrenttime() - eventDate;
            return time;
        }
    }

}
